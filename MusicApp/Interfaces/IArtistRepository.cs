using MusicApp.Models;

namespace MusicApp.Repository
{
    public interface IArtistRepository
    {
        ICollection<Artist> GetArtists();
        Artist GetArtist(int id);
        Artist GetArtist(string name);
        bool ArtistExists(int artistId);
    }
}
