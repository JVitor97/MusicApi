namespace MusicApp.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public int Duration { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
