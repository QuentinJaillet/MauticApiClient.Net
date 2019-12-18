using MauticApiClient.Net.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace MauticApiClient.Net
{
    public class EmailService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public EmailService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task<Emails> Get()
        {
            var client = _httpClientProvider.GetHttpClient();

            try
            {
                var response = await client.GetAsync("emails");
                if (!response.IsSuccessStatusCode)
                    throw new Exception();

                var json = await response.Content.ReadAsStringAsync();
                var emailsJObject = JObject.Parse(json);

                var emails = new Emails()
                {
                    Total = emailsJObject.Root.SelectToken("total").Value<int>()
                };

                foreach (var emailJObject in emailsJObject.Root.SelectToken("emails").Children())
                    emails.Data.Add(JsonConvert.DeserializeObject<Email>(emailJObject.First.ToString()));

                return emails;
            }
            finally
            {
                if (client != null)
                    client.Dispose();
            }
        }
    }
}
