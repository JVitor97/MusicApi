using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Dto;
using MusicApp.Models;
using MusicApp.Repository;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ArtistController : Controller
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;

        public ArtistController(IArtistRepository artistRepository, IMapper mapper)
        {
            _artistRepository = artistRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Artist>))]
        public IActionResult GetArtists()
        {
            var artists = _mapper.Map<List<ArtistDto>>(_artistRepository.GetArtists());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(artists);
        }

        [HttpGet ("{artistId}")]
        [ProducesResponseType(200, Type = typeof(Artist))]
        [ProducesResponseType(400)]
        public IActionResult GetArtist(int artistId)
        {
            if (!_artistRepository.ArtistExists(artistId))
                return NotFound();

            var artist = _mapper.Map<ArtistDto>(_artistRepository.GetArtist(artistId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(artist);
        }

    }

}
