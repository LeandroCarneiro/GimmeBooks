using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Application.Interfaces.Services;
using GimmeBooks.Common;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObject;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace GimmeBooks.Application.AppServices
{
    public class NewsAnaliticsAppService : BaseAppService<NewsAnalitics_vw, NewsAnalitics>
    {
        private readonly INewsAnaliticsBusiness _business;
        private readonly IBookSearcher _bookSearcher;
        private readonly ITweetSearcher _tweetSearcher;
        private readonly INewsSearcher _newsSearcher;

        public NewsAnaliticsAppService(INewsAnaliticsBusiness business, IBookSearcher bookSearcher, ITweetSearcher tweetSearche, INewsSearcher newsSearcher) : base(business)
        {
            _business = business;
            _bookSearcher = bookSearcher;
            _newsSearcher = newsSearcher;
            _tweetSearcher = tweetSearche;
        }

        public async Task<ReadOnlyCollection<Book_vw>> Find(ECategoryType category, string keyWords)
        {
            return new ReadOnlyCollection<Book_vw>(await _bookSearcher.SearchAsync(category, keyWords));
        }
    }
}
