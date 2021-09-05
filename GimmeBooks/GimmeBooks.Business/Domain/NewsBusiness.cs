using GimmeBooks.Application.Interfaces;
using GimmeBooks.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GimmeBooks.Business.Domain
{
    public class NewsBusiness : AppBusiness<News>, INewsBusiness
    {
        public void DisableVersion(long surveyId, int version)
        {
            using (var trans = _uow.BeginTransaction())
            {
            }
        }
    }
}
