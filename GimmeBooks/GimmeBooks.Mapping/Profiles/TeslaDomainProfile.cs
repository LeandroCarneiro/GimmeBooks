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
            CreateMap<UserApp, UserApp_vw>().ReverseMap();
            CreateMap<SurveyVersion, SurveyVersion_vw>().ReverseMap();
            CreateMap<Survey, Survey_vw>().ReverseMap();
            CreateMap<Answer, Answer_vw>().ReverseMap();
            CreateMap<Question, Question_vw>().ReverseMap();
        }
    }
}
