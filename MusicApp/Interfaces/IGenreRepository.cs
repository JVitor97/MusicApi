using MusicApp.Models;

namespace MusicApp.Interfaces
{
    public interface IGenreRepository
    {
        ICollection<Genre> GetGenres();
    }
}
