namespace YouTubePlaylists.Models
{
    using System;

    public class PlaylistDetailsRequestModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Creator { get; set; }

        public double Rating { get; set; }

        public DateTime DateCreated { get; set; }

        public int NumberOfVideos { get; set; }

        public string LinkToDetailsPage { get; set; }
    }
}