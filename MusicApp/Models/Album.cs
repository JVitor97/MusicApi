namespace MusicApp.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public DateTime DateReleased { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public virtual ICollection<Song> Songs { get; set; }


        //public ICollection<AlbumArtist> AlbumArtists { get; set; }
        //public ICollection<AlbumGenre> AlbumGenres { get; set; }
    }
}
