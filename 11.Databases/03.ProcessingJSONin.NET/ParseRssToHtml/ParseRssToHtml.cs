namespace ParseRssToHtml
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParseRssToHtml
    {
        public static void Main()
        {
            var path = "../../videos.xml";

            // Generate the xml file
            if (!File.Exists(path))
            {
                HelperMethods.GenerateBlankXml(path);
            }

            var doc = XDocument.Load(path);

            // Download content from Telerik Academy's RSS and fill the xml file
            HelperMethods.DownloadFile("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw", path);

            // Convert the xml to JSON
            string json = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
            var jsonObj = JObject.Parse(json);

            // Select only video titles and urls
            var videoCollection = from e in jsonObj["feed"]["entry"].Children()
                                  select new
                                  {
                                      Title = e["title"],
                                      Url = e["link"]["@href"]
                                  };

            Console.WriteLine("\r\nVideo Titles:\r\n");

            // Deserialize videos from JSON and add them to the video list
            List<Video> outputVideos = new List<Video>();
            foreach (var video in videoCollection)
            {
                var jsonSerialized = JsonConvert.SerializeObject(video);
                var outputVideo = JsonConvert.DeserializeObject<Video>(jsonSerialized.ToString());
                outputVideos.Add(outputVideo);
            }

            // Print video titles on the console (this was in the task)
            foreach (var item in outputVideos)
            {
                Console.WriteLine("{0}", item.Title);
            }

            // Generate html page containing all videos from the RSS feed of the Academy & open it in the default browser
            File.WriteAllText("videos.html", HelperMethods.BuildHtml(outputVideos));
            System.Diagnostics.Process.Start("videos.html");
        }
    }
}
