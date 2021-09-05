using AutoMapper;
using GimmeBooks.Domain;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels;
using GimmeBooks.ViewModels.AppObjects;

namespace GimmeBooks.Mapping.Profiles
{
    public class TeslaDomainProfile : Profile
    {
        public TeslaDomainProfile()
        {
            CreateMap<EntityBase<long>, EntityBase_vw<long>>().ReverseMap();
            CreateMap<News, News_vw>().ReverseMap();
        }
    }
}
