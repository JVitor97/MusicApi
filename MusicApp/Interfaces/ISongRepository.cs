using MusicApp.Models;

namespace MusicApp.Interfaces
{
    public interface ISongRepository
    {
        ICollection<Song> GetSongs();
        Song GetSong(int id);
        Song GetSong(string name);
        bool SongExists(int id);
    }
}
