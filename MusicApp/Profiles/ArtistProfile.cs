using AutoMapper;
using MusicApp.Dto;
using MusicApp.Models;

namespace MusicApp.Profiles
{
    public class ArtistProfile : Profile
    {
        public ArtistProfile()
        {
            CreateMap<Artist, ArtistDto>();
        }
    }
}
