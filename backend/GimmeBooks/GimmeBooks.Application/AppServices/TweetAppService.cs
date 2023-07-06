using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Application.Interfaces.Services;
using GimmeBooks.Common;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObject;
using GimmeBooks.ViewModels.AppObjects;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace GimmeBooks.Application.AppServices
{
    public class TweetAppService : BaseAppService<Tweet_vw, Tweet>
    {
        private readonly ITweetBusiness _business;
        private readonly ITweetSearcher _searcher;

        public TweetAppService(ITweetBusiness business, ITweetSearcher searcher) : base(business)
        {
            _business = business;
            _searcher = searcher;
        }

        public async Task<ReadOnlyCollection<Tweet_vw>> Find(string keyWords)
        {
            return new ReadOnlyCollection<Tweet_vw>(await _searcher.SearchAsync(keyWords));
        }
    }
}
