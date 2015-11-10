/*Write a console application, which searches for news articles by given a query string and a count of articles to retrieve.

    The application should ask the user for input and print the Titles and URLs of the articles.
    For news articles search, use the Feedzilla API and use one of WebClient, HttpWebRequest or HttpClient.
*/

namespace ConsumeWebServices
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Startup
    {
        public static void Main()
        {
            /* Since the Feedzilla API is not working, I decided to use the Google Books API. Enjoy the spaghetti ;)
            */
            SearchGoogleBooks("doctor", 3);
            SearchGoogleBooks("javascript the good parts", 2);
            SearchGoogleBooks("астрофизика", 2);
        }

        public static async Task<JObject> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);

            // will throw an exception if not successful
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return await Task.Run(() => JObject.Parse(content));
        }

        public static void SearchGoogleBooks(string bookName, int count)
        {
            string apiUrl = "https://www.googleapis.com/books/v1/volumes?q=";
            string[] searchKeys = bookName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string bookNameQueryString = string.Join("+", searchKeys);
            string maxResults = "&maxResults=" + count;
            string googleBooksApiKey = "&key=" + "AIzaSyDwTFKD3diDfEk80VJBEOQP8RNf97gJrvY";

            string queryString = apiUrl + bookNameQueryString + maxResults + googleBooksApiKey;

            var response = GetAsync(queryString);

            var resultingVolume = JsonConvert.DeserializeObject<BookVolume>(response.Result.ToString());

            var resultingBooks = new Dictionary<string, string>();
            foreach (var book in resultingVolume.Items)
            {
                resultingBooks.Add(book.VolumeInfo.Title, book.VolumeInfo.InfoLink.Substring(0, book.VolumeInfo.InfoLink.IndexOf('&')));
            }

            Console.WriteLine("Searching <{0}> returns {1} results. Top {2} results are:\r\n", bookName, resultingVolume.TotalItems, count);
            foreach (var item in resultingBooks)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
