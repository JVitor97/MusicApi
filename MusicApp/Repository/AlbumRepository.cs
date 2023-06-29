using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using MusicApp.Interfaces;
using MusicApp.Models;

namespace MusicApp.Repository
{
    public class AlbumRepository : IAlbumRepository
    {

        protected readonly DataContext _context;

        public AlbumRepository(DataContext context)
        {
            _context = context;
        }

        public bool AlbumExists(int albumId)
        {
            return _context.Albums.Any(a => a.AlbumId == albumId);
        }

        public Album GetAlbum(int id)
        {
            return _context.Albums
                .Include(a => a.Songs)
                .Where(a => a.AlbumId == id)
                .FirstOrDefault();
        }

        public Album GetAlbum(string name)
        {
            return _context.Albums
                .Include(n => n.Songs)
                .Where(n => n.AlbumName == name)
                .FirstOrDefault();
        }

        public Album GetAlbum(DateTime releaseDate)
        {
            return _context.Albums.Where(d => d.DateReleased == releaseDate).FirstOrDefault();
        }

        public ICollection<Album> GetAlbums()
        {
            return _context.Albums.OrderBy(a => a.AlbumId).ToList();
        }
    }
}
