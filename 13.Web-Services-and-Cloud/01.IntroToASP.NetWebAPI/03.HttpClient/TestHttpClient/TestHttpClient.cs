namespace TestHttpClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    class TestHttpClient
    {
        static void Main()
        {
            Task t = new Task(DownloadPageAsync);
            t.Start();
            Console.WriteLine("Downloading page...");
            Console.ReadLine();
        }

        static async void DownloadPageAsync()
        {
            // ... Target page.
            string page = "http://telerikacademy.com/";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                // ... Display the result.
                if (result != null)
                {
                    Console.WriteLine(result.Substring(0, 500) + "...");
                }
            }
        }
    }
}
