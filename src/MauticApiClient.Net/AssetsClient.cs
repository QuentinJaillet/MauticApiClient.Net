using System.Collections.Generic;
using MauticApiClient.Net.Models.Assets;
using RestSharp;

namespace MauticApiClient.Net
{
    public class AssetsClient : ClientBase, IAssetsClient
    {
        private const string DeleteAssetUrl = "assets/{id}/delete";
        private const string EditAssetUrl = "assets/{id}/edit";
        private const string CreateAssetUrl = "assets/new";
        private const string GetAssetUrl = "assets/{id}";
        private const string ListAssetUrl = "assets";

        public AssetsClient(string username, string password, string url) : base(username, password, url)
        {
        }

        public void CreateAsset(string title, string storageLocation, string file)
        {
            var request = new RestRequest(CreateAssetUrl);
            request.AddQueryParameter("title", title);
            request.AddQueryParameter("storageLocation", storageLocation);
            request.AddQueryParameter("file", file);

            var response = RestClient.Post(request);
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                return;

            throw new System.NotImplementedException();
        }

        public void DeleteAsset(int id)
        {
            var request = new RestRequest(DeleteAssetUrl);
            request.AddUrlSegment("id", id);

            var response = RestClient.Delete(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return;

            throw new System.NotImplementedException();
        }

        public void Edit(string title, string storageLocation, string file, bool createifnotexist = false)
        {
            var request = new RestRequest(EditAssetUrl);
            // request.AddUrlSegment("id", id);

            throw new System.NotImplementedException();
        }

        public Asset GetAsset(int id)
        {
            var request = new RestRequest(GetAssetUrl);
            request.AddUrlSegment("id", id);

            var response = RestClient.Get<Asset>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response.Data;

            throw new System.NotImplementedException();
        }

        public List<Asset> ListAssets(ListAssetRequest model)
        {
            var request = new RestRequest(ListAssetUrl);
            request.AddQueryParameter("search", model.Search);
            request.AddQueryParameter("start", model.Start.ToString());
            request.AddQueryParameter("limit", model.Limit.ToString());
            request.AddQueryParameter("orderBy", model.OrderBy);
            request.AddQueryParameter("orderByDir", model.OrderByDir);
            request.AddQueryParameter("publishedOnly", model.PublishedOnly);
            request.AddQueryParameter("minimal", model.Minimal);

            var response = RestClient.Get<List<Asset>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response.Data;

            throw new System.NotImplementedException();
        }
    }
}
