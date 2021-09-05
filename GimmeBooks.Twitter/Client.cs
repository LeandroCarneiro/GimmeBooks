using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObject;
using LinqToTwitter;
using LinqToTwitter.Common;
using LinqToTwitter.OAuth;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GimmeBooks.Twitter
{
    public class Client
    {
        private readonly TwitterContext _twitterCtx;

        public Client(IConfiguration config)
        {
            var settings = config.GetValue<ApiSettings>("TwitterApi");
            var auth = Authorization(settings.Key, settings.Secret);

            _twitterCtx = new TwitterContext(auth);
        }

        private IAuthorizer Authorization(string key, string secret)
        {
            var auth = new ApplicationOnlyAuthorizer()
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = key,
                    ConsumerSecret = secret
                },
            };

            return auth;
        }

        public async Task<List<Tweet_vw>> DoSearchAsync(string searchTerm)
        {
            Search? searchResponse =
                await
                _twitterCtx.Search.Where(
                    x=>x.Query == searchTerm 
                    && x.Type == SearchType.Search
                    &&   x.IncludeEntities == true 
                    &&   x.TweetMode == TweetMode.Extended
                 )
                .FirstOrDefaultAsync();

            var list = new List<Tweet_vw>();

            if (searchResponse?.Statuses != null)
                
                searchResponse.Statuses.ForEach(tweet =>
                    list.Add(new Tweet_vw()
                            {
                                User = tweet.User?.ScreenNameResponse,
                                Text = tweet.Text ?? tweet.FullText
                            }));

            return list;
        }
    }
}
