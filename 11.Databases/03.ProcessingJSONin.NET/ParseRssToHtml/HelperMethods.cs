namespace ParseRssToHtml
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    public static class HelperMethods
    {
        public static void GenerateBlankXml(string path)
        {
            XDocument doc = new XDocument();
            doc.Add(new XElement("root"));
            doc.Save(path);
        }

        public static void DownloadFile(string url, string outputFileUrl)
        {
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();

            Console.WriteLine("Downloading from \"{0}\" .......\n\n", url);

            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(url, "..\\..\\videos.xml");

            Console.WriteLine("Successfully downloaded file: \"{0}\"", outputFileUrl, url);
        }

        public static string BuildHtml(List<Video> inputVideos)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<!DOCTYPE html><html lang=""en"" xmlns=""http:////www.w3.org//1999//xhtml""><head><meta charset=""utf-8"" /><title></title></head><body>");

            foreach (var video in inputVideos)
            {
                sb.Append(@"<div style=""float: left; margin-right: 5px;"">");
                sb.Append("<p>");
                sb.Append(video.Title);
                sb.Append("</p>");
                sb.Append(@"<iframe width=""427"" height=""240"" src=""");
                sb.Append(NormalizeYoutubeUrl(video.Url));
                sb.Append(@""" frameborder=""0"" allowfullscreen></iframe>");
                sb.Append("</div>");
            }

            sb.Append("</body></html>");
            return sb.ToString();
        }

        public static string NormalizeYoutubeUrl(string url)
        {
            // In order to embed youtube videos, urls need to be normalized like follows:
            string pattern = "watch\\?v=";
            string replacement = "embed/";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(url, replacement);
            return result;
        }
    }
}
