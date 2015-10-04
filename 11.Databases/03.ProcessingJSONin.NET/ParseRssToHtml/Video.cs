namespace ParseRssToHtml
{
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }
    }
}