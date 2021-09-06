using AutoMapper;
using GimmeBooks.Domain;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels;
using GimmeBooks.ViewModels.AppObject;
using GimmeBooks.ViewModels.AppObjects;

namespace GimmeBooks.Mapping.Profiles
{
    public class AppDomainProfile : Profile
    {
        public AppDomainProfile()
        {
            CreateMap<EntityBase<long>, EntityBase_vw<long>>().ReverseMap();
            CreateMap<News, News_vw>().ReverseMap();
            CreateMap<Book, Book_vw>().ReverseMap();
            CreateMap<Tweet, Tweet_vw>().ReverseMap();
            CreateMap<NewsAnalitics, NewsAnalitics_vw>().ReverseMap();
        }
    }
}
