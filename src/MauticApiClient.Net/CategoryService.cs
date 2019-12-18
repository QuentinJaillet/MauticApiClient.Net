using MauticApiClient.Net.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MauticApiClient.Net
{
    public class CategoryService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public CategoryService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task<Categories> Get()
        {
            var client = _httpClientProvider.GetHttpClient();

            try
            {
                var response = await client.GetAsync("categories");

                if (!response.IsSuccessStatusCode)
                    throw new Exception();

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Categories>(json);
            }
            finally
            {
                if (client != null)
                    client.Dispose();
            }
        }

        public async Task Add(string name, string bundle)
        {
            var client = _httpClientProvider.GetHttpClient();

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(new NewCategory { Name = name, Bundle = bundle }), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("categories/new", content);

                if (!response.IsSuccessStatusCode)
                    throw new Exception();
            }
            finally
            {
                if (client != null)
                    client.Dispose();
            }
        }
    }
}
