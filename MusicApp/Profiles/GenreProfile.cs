using AutoMapper;
using MusicApp.Dto;
using MusicApp.Models;

namespace MusicApp.Profiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreDto>();
        }
    }
}
