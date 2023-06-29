using MusicApp.Models;

namespace MusicApp.Interfaces
{
    public interface IAlbumRepository
    {
        ICollection<Album> GetAlbums();
        Album GetAlbum(int id);
        Album GetAlbum(string name);
        Album GetAlbum(DateTime releaseDate);
        bool AlbumExists (int albumId);
    }
}
