using GimmeBooks.Common;
using LinqToTwitter.OAuth;

namespace GimmeBooks.Twitter
{
    public static class Setup
    {
        public static IAuthorizer Authorization(ApiSettings settings)
        {
            var auth = new SingleUserAuthorizer()
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = settings.Key,
                    ConsumerSecret = settings.Secret,
                    AccessTokenSecret = settings.TokenSecret,
                    AccessToken = settings.AccessToken,
                    //OAuthToken = "AAAAAAAAAAAAAAAAAAAAAGajTQEAAAAA3CLn069gm5BYeqavA68SoalXnhs%3DPrds7E0yEtETwYB6UAhEEVKRPigkpwVSySI8RxfEbtwbjEqsAS",
                },
            };

            return auth;
        }
    }
}
