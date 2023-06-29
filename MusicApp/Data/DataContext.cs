using Microsoft.EntityFrameworkCore;
using MusicApp.Models;

namespace MusicApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    AlbumName = "A Dramatic Turn of Events",
                    DateReleased = DateTime.Parse("10-03-2011"),
                    GenreId = 1,
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 2,
                    AlbumName = "Black Clouds and Silver Linings",
                    DateReleased = DateTime.Parse("15-10-2009"),
                    GenreId = 1,
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 3,
                    AlbumName = "É o Tcham no Havai",
                    DateReleased = DateTime.Parse("05-05-2000"),
                    GenreId = 2,
                    ArtistId = 2
                }
                );
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    ArtistName = "Dream Theater",
                    GenreId = 1
                },
                new Artist
                {
                    ArtistId = 2,
                    ArtistName = "É o Tcham",
                    GenreId = 2
                }
                );
            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    GenreName = "Progressive Metal"
                    
                },
                new Genre
                {
                    GenreId = 2,
                    GenreName = "Axé Music"
                }
                );
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    AlbumId = 1,
                    ArtistId = 1,
                    Duration = 18,
                    GenreId = 1,
                    SongName = "On The Backs of Angels",
                    
                },
                new Song
                {
                    SongId = 2,
                    AlbumId = 1,
                    ArtistId = 1,
                    Duration = 9,
                    GenreId = 1,
                    SongName = "Breaking All Illusions",

                },
                new Song
                {
                    SongId = 3,
                    AlbumId = 1,
                    ArtistId = 1,
                    Duration = 18,
                    GenreId = 1,
                    SongName = "Lost Not Forgotten",

                },
                new Song
                {
                    SongId = 4,
                    AlbumId = 1,
                    ArtistId= 1,
                    Duration = 11,
                    GenreId = 1,
                    SongName = "This is The Life",
                },
                new Song
                {
                    SongId = 5,
                    AlbumId = 2,
                    ArtistId = 1,
                    Duration = 14,
                    GenreId = 1,
                    SongName = "The Count of Tuscany",
                },
                new Song
                {
                    SongId = 6,
                    AlbumId = 3,
                    ArtistId = 2,
                    Duration = 4,
                    GenreId = 2,
                    SongName = "A Loira do Tcham",
                }
                );
        }
    }
}
