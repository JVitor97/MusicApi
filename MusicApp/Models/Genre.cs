namespace MusicApp.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Artist> Artists { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
