namespace RestFullHelper
{
    public class Config
    {
        public readonly string Uri;
        private readonly string _apiKey;

        public Config(string uri)
        {
            Uri = uri;
        }

        public Config(string url, string apikeyQueryName, string apiKey)
        {
            Uri = url + $"?{apikeyQueryName}={apiKey}";
            _apiKey = apiKey;
        }
    }
}
