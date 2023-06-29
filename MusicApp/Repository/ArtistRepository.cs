using MusicApp.Data;
using MusicApp.Models;

namespace MusicApp.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        protected readonly DataContext _context;
        
        public ArtistRepository(DataContext context)
        {
            _context = context;    
        }
        public Artist GetArtist(int id)
        {
            return _context.Artists.Where(a => a.ArtistId == id).FirstOrDefault();
        }
        public Artist GetArtist(string name)
        {
            return _context.Artists.Where(n => n.ArtistName == name).FirstOrDefault();
        }
        public ICollection<Artist> GetArtists()
        {
            return _context.Artists.OrderBy(a => a.ArtistId).ToList();
        }
        public bool ArtistExists(int artistid)
        {
            return _context.Artists.Any(a => a.ArtistId == artistid); 
        }


    }
}
