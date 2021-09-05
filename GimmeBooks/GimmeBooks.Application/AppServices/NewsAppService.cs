using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObjects;

namespace GimmeBooks.Application.AppServices
{
    public class NewsAppService : BaseAppService<News_vw, News>
    {
        readonly INewBusiness _business;

        public NewsAppService(INewBusiness business) : base(business)
        {
            _business = business;
        }

        public override void Update(News_vw entity)
        {
            var newSurvey = Resolve(entity);            
        }
    }
}
