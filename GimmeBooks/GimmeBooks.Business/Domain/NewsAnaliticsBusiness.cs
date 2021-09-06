using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Domain.Entities;

namespace GimmeBooks.Business.Domain
{
    public class NewsAnaliticsBusiness : AppBusiness<NewsAnalitics>, INewsAnaliticsBusiness
    {
        public void DisableVersion(long surveyId, int version)
        {
            using (var trans = _uow.BeginTransaction())
            {
            }
        }
    }
}
