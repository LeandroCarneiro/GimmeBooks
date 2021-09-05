using LinqToTwitter.OAuth;

namespace GimmeBooks.Twitter
{
    public static class Setup
    {
        public static IAuthorizer Authorization(string key, string secret)
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
    }
}
