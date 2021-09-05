using GimmeBooks.Common;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GimmeBooks.Application.Interfaces.Services
{
    public interface INewsSearcher
    {
        Task<List<News_vw>> SearchAsync(ECategoryType categatory);
    }
}
