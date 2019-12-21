using RestSharp;
using RestSharp.Authenticators;

namespace MauticApiClient.Net
{
    public abstract class ClientBase
    {
        protected readonly IRestClient RestClient;

        public ClientBase(string username, string password, string url)
        {
            RestClient = new RestClient(url);
            RestClient.Authenticator = new HttpBasicAuthenticator(username, password);
        }
    }
}
