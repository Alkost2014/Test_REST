using AutoMapper;
using SDK.Models;
using WebApi.DTOs;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DocumentSdk, DocumentDto>();
        }
    }
}
