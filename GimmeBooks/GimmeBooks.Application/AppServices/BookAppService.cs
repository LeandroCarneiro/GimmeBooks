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
    public class BookAppService : BaseAppService<Book_vw, Book>
    {
        private readonly IBookBusiness _business;
        private readonly IBookSearcher _searcher;

        public BookAppService(IBookBusiness business, IBookSearcher searcher) : base(business)
        {
            _business = business;
            _searcher = searcher;
        }

        public async Task<ReadOnlyCollection<Book_vw>> Find(ECategoryType category, string keyWords)
        {
            return new ReadOnlyCollection<Book_vw>(await _searcher.SearchAsync(category, keyWords));
        }
    }
}
