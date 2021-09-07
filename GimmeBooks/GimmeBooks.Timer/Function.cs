using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace GimmeBooks.Timer
{
    public class Function
    {
        private readonly HttpClient _client;
        public Function(HttpClient httpClient)
        {
            this._client = httpClient;
        }

        [FunctionName("Function")]
        public async Task Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            try
            {
                log.LogInformation("running");
                var jobUrl = "http://localhost:51150/gimmeBooks/api/NewsAnalitics";
                using (var httpClient = new HttpClient())
                {
                    var url = @jobUrl;
                    httpClient.BaseAddress = new Uri(url);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    log.LogInformation("Will post now");
                    await httpClient.PostAsync(url, null);
                    log.LogInformation("finished");
                }
            }
            catch (Exception ex)
            {
                log.LogError($"The application could not process your request " + ex);
                throw;
            }
        }
    }
}
