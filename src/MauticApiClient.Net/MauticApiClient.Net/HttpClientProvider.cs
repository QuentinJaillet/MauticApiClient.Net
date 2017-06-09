using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MauticApiClient.Net
{
    public class HttpClientProvider : IHttpClientProvider
    {
        private readonly string _baseUrl;
        private readonly string _username;
        private readonly string _password;

        public HttpClientProvider(string baseUrl, string username, string password)
        {
            _baseUrl = baseUrl;
            _username = username;
            _password = password;
        }

        public HttpClient GetHttpClient()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(_baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", _username, _password));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            return client;
        }
    }
}
