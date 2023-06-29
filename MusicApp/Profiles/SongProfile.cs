using AutoMapper;
using MusicApp.Dto;
using MusicApp.Models;

namespace MusicApp.Profiles
{
    public class SongProfile : Profile
    {
        public SongProfile()
        {
            CreateMap<Song, SongDto>();
        }
    }
}
