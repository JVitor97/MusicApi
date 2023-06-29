namespace MusicApp.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public ICollection<Album> Albums { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
