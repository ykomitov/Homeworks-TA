namespace YouTubePlaylists.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Rating
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public int Value { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int PlaylistId { get; set; }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }
    }
}