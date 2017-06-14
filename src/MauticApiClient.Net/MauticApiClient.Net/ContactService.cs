using MauticApiClient.Net.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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

        public async Task<Contacts> Get()
        {
            var client = _httpClientProvider.GetHttpClient();

            try
            {
                var response = await client.GetAsync("contacts");
                if (!response.IsSuccessStatusCode)
                    throw new Exception();

                var json = await response.Content.ReadAsStringAsync();
                var emailsJObject = JObject.Parse(json);

                var contacts = new Contacts()
                {
                    Total = emailsJObject.Root.SelectToken("total").Value<int>()
                };

                foreach (var emailJObject in emailsJObject.Root.SelectToken("contacts").Children())
                    contacts.Data.Add(JsonConvert.DeserializeObject<Contact>(emailJObject.First.ToString()));

                return contacts;
            }
            finally
            {
                if (client != null)
                    client.Dispose();
            }
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
