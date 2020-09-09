using AutoMapper;
using Lunitor.MediaServerMonitor.Server.Models;
using Lunitor.MediaServerMonitor.Shared;

namespace Lunitor.MediaServerMonitor.Server
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Session, SessionDto>()
                .ForMember(dto => dto.IsAdminOrService, m => m.MapFrom(model => !model.IsNotAdmin))
                .ForMember(dto => dto.NowPlayingItemName, m => m.MapFrom(model =>
                    (model.NowPlaying) ? $"{model.NowPlayingItem.SeriesName} - {model.NowPlayingItem.Name}" : ""));
        }
    }
}
