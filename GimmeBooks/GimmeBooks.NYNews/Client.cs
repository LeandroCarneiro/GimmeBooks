using GimmeBooks.Application.Interfaces.Services;
using GimmeBooks.Common;
using GimmeBooks.NYNews.Objs;
using GimmeBooks.ViewModels.AppObject;
using GimmeBooks.ViewModels.AppObjects;
using Microsoft.Extensions.Configuration;
using RestFullHelper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GimmeBooks.NYNews
{
    public class Client : INewsSearcher
    {
        private readonly ApiClient _client;

        public Client(IConfiguration config)
        {
            var settings = config.GetValue<ApiSettings>("NYApi");
           
            _client = new ApiClient(
                new Config(
                    settings.Url, 
                    settings.KeyQueryName, 
                    settings.Key, 
                    settings.Secret
                    ));
        }

        public async Task<List<News_vw>> SearchAsync(string categatory)
        {
            var result = await _client.SendAsync<NYResult>(new ObjRequest()
            {
                Method = $"topstories/v2/{categatory}.json",
                Parameters = "",
                Type = ERequestType.Get
            });

            if (result != null && result.Results != null && result.Results.Any() && result.Status == "Ok")
                return result.Results.ToList();

            return default(List<News_vw>);
        }
    }
}
