using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Domain.Entities;

namespace GimmeBooks.Business.Domain
{
    public class NewsBusiness : AppBusiness<News>, INewBusiness
    {
        public void DisableVersion(long surveyId, int version)
        {
            using (var trans = _uow.BeginTransaction())
            {
            }
        }
    }
}
