using AutoMapper;
using MusicApp.Dto;
using MusicApp.Models;

namespace MusicApp.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<Album, AlbumDto>();
        }
    }
}
