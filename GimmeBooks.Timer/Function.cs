using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObject;
using GimmeBooks.ViewModels.AppObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestFullHelper;

namespace GimmeBooks.Timer
{
    public static class Function
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            try
            {
                log.LogInformation("C# HTTP trigger function processed a request.");

                var client = GetClient();
                log.LogInformation("getting news ");
                var news = await client.SendAsync<List<News_vw>>(new ObjRequest()
                {
                    Method = "News",
                    Type = ERequestType.Get,
                    Parameters = "?category=" + ECategoryType.World
                });

                log.LogInformation("getting books ");
                var books = client.SendAsync<List<Book_vw>>(new ObjRequest()
                {
                    Method = "Book",
                    Type = ERequestType.Get,
                    Parameters = "?category=" + ECategoryType.World + "&keywords=" + news.FirstOrDefault().Title
                });

                log.LogInformation("getting tweets");
                var tweets = client.SendAsync<List<Book_vw>>(new ObjRequest()
                {
                    Method = "Tweet",
                    Type = ERequestType.Get,
                    Parameters = "?keywords=" + news.FirstOrDefault().Title
                });

                return new ContentResult
                {
                    Content = JsonConvert.SerializeObject(
                        new
                        {
                            news = news,
                            tweets = await tweets,
                            books = await books
                        }),
                    ContentType = "application/json"
                };
            }
            catch (Exception ex)
            {
                log.LogError($"The application could not process your request " + ex);
                throw;
            }
        }

        private static ApiClient GetClient()
        {
            var client = new ApiClient(new Config("https://localhost:44331/gimmeBooks/api"));
            return client;
        }
    }
}
