﻿using GimmeBooks.Application.AppServices;
using GimmeBooks.ViewModels.AppObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GimmeBooks.Api.Controllers
{
    public class NewsAnaliticsController : BaseController
    {
        private readonly BookAppService bookAppService;
        private readonly NewsAppService newsAppService;
        private readonly TweetAppService tweetAppService;

        public NewsAnaliticsController(
            BookAppService bookAppService,
            NewsAppService newsAppService,
            TweetAppService tweetAppService
            )
        {
            this.bookAppService = bookAppService;
            this.newsAppService = newsAppService;
            this.tweetAppService = tweetAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Post()
        {
            var news = await newsAppService.GetAll(Common.ECategoryType.World);
            var books = bookAppService.Find(Common.ECategoryType.World, news.FirstOrDefault().Title);
            var tweets = tweetAppService.Find(news.FirstOrDefault().Title);

            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(
                    new NewsAnalitics_vw()
                    {
                        NewsTitle = news.FirstOrDefault().Title,
                        RelatedTweetsCount = (await tweets).Count,
                        RelatedBooksCount = (await books).Count,
                        Date = DateTime.Now 
                    }),
                ContentType = "application/json"
            };
        }
    }
}