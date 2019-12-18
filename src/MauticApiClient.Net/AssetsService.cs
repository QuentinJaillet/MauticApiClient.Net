using System.Collections.Generic;
using MauticApiClient.Net.Models.Assets;

namespace MauticApiClient.Net
{
    public class AssetsService : IAssetsService
    {
        public void CreateAsset(string title, string storageLocation, string file)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAsset(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(string title, string storageLocation, string file, bool createifnotexist = false)
        {
            throw new System.NotImplementedException();
        }

        public Asset GetAsset(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Asset> ListAssets(ListAssetRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
