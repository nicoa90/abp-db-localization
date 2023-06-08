using AutoMapper;
using Localization.Dtos;

namespace Localization;

public class ApplicationAutoMapperProfile : Profile
{
    public ApplicationAutoMapperProfile()
    {
        CreateMap<LocalizedResource, LocalizedResourceDto>().ReverseMap();
    }
}
