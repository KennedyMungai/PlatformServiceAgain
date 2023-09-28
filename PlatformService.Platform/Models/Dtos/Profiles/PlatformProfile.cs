using AutoMapper;

namespace PlatformService.Platform.Models.Dtos.Profiles;


public class PlatformProfile : Profile
{
    public PlatformProfile()
    {
        CreateMap<PlatformModel, PlatformReadDto>().ReverseMap();
        CreateMap<PlatformModel, PlatformCreateDto>().ReverseMap();
    }
}