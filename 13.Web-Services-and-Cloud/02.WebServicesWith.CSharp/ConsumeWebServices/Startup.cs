/*Write a console application, which searches for news articles by given a query string and a count of articles to retrieve.

    The application should ask the user for input and print the Titles and URLs of the articles.
    For news articles search, use the Feedzilla API and use one of WebClient, HttpWebRequest or HttpClient.
*/

namespace ConsumeWebServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Startup
    {
        public static void Main()
        {
            string googleBooksApiKey = "AIzaSyDwTFKD3diDfEk80VJBEOQP8RNf97gJrvY";

            string testUrl = "https://www.googleapis.com/books/v1/volumes?q=javascript+the+good+parts+inauthor:Douglas+Crockford+&maxResults=1&key=";

            var task = GetAsync(testUrl + googleBooksApiKey);

            dynamic json = JsonConvert.DeserializeObject<BookVolume>(task.Result.ToString());
           // var result = DeserializeFromJson<BookVolume>(task.Result): 
            Console.WriteLine();
        }

        public static async Task<JObject> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);

            //will throw an exception if not successful
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return await Task.Run(() => JObject.Parse(content));
        }
    }
}
