using GimmeBooks.ViewModels.AppObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GimmeBooks.Application.Interfaces.Services
{
    public interface ITweetSearcher
    {
        Task<List<Tweet_vw>> SearchAsync(string searchTerm);
    }
}
