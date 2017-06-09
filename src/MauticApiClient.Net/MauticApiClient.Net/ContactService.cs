using MauticApiClient.Net.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MauticApiClient.Net
{
    public class ContactService 
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public ContactService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task<Contact> GetById(int idContact)
        {
            var contact = new Contact();


            //  Fournisseur de l'url de base 
            var client = _httpClientProvider.GetHttpClient();

            var url = "contacts/" + idContact;


                HttpResponseMessage response1 = await client.GetAsync(url);
            if (response1.IsSuccessStatusCode)
            {
                var product = await response1.Content.ReadAsStringAsync();

                contact = JsonConvert.DeserializeObject<Contact>(product);


            }

            return contact;

        }
    }
}
