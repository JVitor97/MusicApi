using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Dto;
using MusicApp.Interfaces;
using MusicApp.Models;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SongController : Controller
    {
        private readonly ISongRepository _songRepository;
        private readonly IMapper _mapper;

        public SongController(ISongRepository songRepository, IMapper mapper)
        {
            _songRepository = songRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Song>))]

        public IActionResult GetSong() 
        {
            var songs = _mapper.Map<List<SongDto>>(_songRepository.GetSongs());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(songs);
            
        }

        [HttpGet ("{songId}")]
        [ProducesResponseType(200, Type=typeof(Song))]
        [ProducesResponseType (400)]

        public IActionResult GetSongs(int songId) 
        {
            if (!_songRepository.SongExists(songId))
                return NotFound();

            var song = _mapper.Map<SongDto>(_songRepository.GetSong(songId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(song);
        }
    }
}
