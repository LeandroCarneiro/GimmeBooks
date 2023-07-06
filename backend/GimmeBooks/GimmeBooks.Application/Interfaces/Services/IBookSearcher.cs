using GimmeBooks.Common;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObject;
using GimmeBooks.ViewModels.AppObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GimmeBooks.Application.Interfaces.Services
{
    public interface IBookSearcher
    {
        Task<List<Book_vw>> SearchAsync(ECategoryType category, string keyWords);
    }
}
