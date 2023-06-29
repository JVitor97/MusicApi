using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Dto;
using MusicApp.Interfaces;
using MusicApp.Models;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlbumController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly IMapper _mapper;

        public AlbumController(IAlbumRepository albumRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Album>))]
        public IActionResult GetAlbums()
        {
            var albums = _mapper.Map<List<AlbumDto>>(_albumRepository.GetAlbums());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(albums);
        }

        [HttpGet("{albumId}")]
        [ProducesResponseType(200, Type = typeof(Album))]
        public IActionResult GetAlbum(int albumId)
        {
            if (!_albumRepository.AlbumExists(albumId))
                return NotFound();
            
            var album = _mapper.Map<AlbumDto>(_albumRepository.GetAlbum(albumId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(album);
        }

    }
}
