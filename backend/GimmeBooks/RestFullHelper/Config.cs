namespace RestFullHelper
{
    public class Config
    {
        public readonly string Url;
        private readonly string _apiKey;
        private readonly string _apiSecret;
        public readonly string Permissions;

        public Config(string uri)
        {
            Url = uri;
        }

        public Config(string url, string apikeyQueryName="", string apiKey="", string apiSecretQueryName="", string secret="")
        {
            Url = url;
            _apiKey = apiKey;
            _apiSecret = secret;

            if(!(string.IsNullOrEmpty(apikeyQueryName) && string.IsNullOrEmpty(apiKey)))
            {
                Permissions = $"?{apikeyQueryName}={apiKey}";

                if (!string.IsNullOrEmpty(apikeyQueryName) && !string.IsNullOrEmpty(secret))
                    Permissions += $"&{apiSecretQueryName}={secret}";
            }
        }
    }
}
