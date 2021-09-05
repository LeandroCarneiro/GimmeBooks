using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Application.Interfaces.Services;
using GimmeBooks.Common;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObjects;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace GimmeBooks.Application.AppServices
{
    public class NewsAppService : BaseAppService<News_vw, News>
    {
        private readonly INewBusiness _business;
        private readonly INewsSearcher _newsSearcher;

        public NewsAppService(INewBusiness business, INewsSearcher newsSearcher) : base(business)
        {
            _business = business;
            _newsSearcher = newsSearcher;
        }

        public override void Update(News_vw entity)
        {
            var newSurvey = Resolve(entity);            
        }

        public async Task<ReadOnlyCollection<News_vw>> GetAll(ECategoryType category)
        {
            return new ReadOnlyCollection<News_vw>(await _newsSearcher.SearchAsync(category));
        }
    }
}
