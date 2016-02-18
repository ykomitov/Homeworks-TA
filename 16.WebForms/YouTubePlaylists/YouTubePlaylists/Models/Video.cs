namespace YouTubePlaylists.Models
{
    using System.Collections.Generic;

    public class Video
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}