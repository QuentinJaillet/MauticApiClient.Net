using System.Net.Http;

namespace MauticApiClient.Net
{
    public interface IHttpClientProvider
    {
        HttpClient GetHttpClient();
    }
}