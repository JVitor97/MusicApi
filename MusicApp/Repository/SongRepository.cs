using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using MusicApp.Interfaces;
using MusicApp.Models;

namespace MusicApp.Repository
{
    public class SongRepository : ISongRepository
    {
        private readonly DataContext _context;

        public SongRepository(DataContext context)
        {
            _context = context;
        }

        public Song GetSong(int id)
        {
            return _context.Songs
                .Where(s => s.SongId == id)
                .FirstOrDefault();
        }

        public Song GetSong(string name)
        {
            return _context.Songs
                .Where(n => n.SongName == name)
                .FirstOrDefault();
        }

        public ICollection<Song> GetSongs()
        {
           return _context.Songs
                .OrderBy(s => s.SongId).ToList();
        }

        public bool SongExists(int songId)
        {
            return _context.Songs.Any(s => s.SongId == songId);
        }
    }
}
