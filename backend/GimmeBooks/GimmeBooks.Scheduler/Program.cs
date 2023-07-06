using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObject;
using GimmeBooks.ViewModels.AppObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using RestFullHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GimmeBooks.Scheduler
{
    public class Program
    {
        [FunctionName("Scheduler")]
        public async Task<IActionResult> Run([TimerTrigger("0 */4 * * * *")] TimerInfo myTimer, TraceWriter log)
        {
            try
            {
                log.Info("C# HTTP trigger function processed a request.");

                var client = GetClient();
                log.Info("getting news ");
                var news = await client.SendAsync<List<News_vw>>(new ObjRequest()
                {
                    Method = "News",
                    Type = ERequestType.Get,
                    Parameters = "?category=" + ECategoryType.World
                });

                log.Info("getting books ");
                var books = client.SendAsync<List<Book_vw>>(new ObjRequest()
                {
                    Method = "Book",
                    Type = ERequestType.Get,
                    Parameters = "?category=" + ECategoryType.World + "&keywords=" + news.FirstOrDefault().Title
                });

                log.Info("getting tweets");
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
                log.Error($"The application could not process your request " + ex);
                throw;
            }
        }

        private ApiClient GetClient()
        {
            var client = new ApiClient(new Config("https://localhost:44331/gimmeBooks/api"));
            return client;
        }
    }
}
