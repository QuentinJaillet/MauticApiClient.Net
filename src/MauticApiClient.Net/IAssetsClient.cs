using System.Collections.Generic;
using MauticApiClient.Net.Models.Assets;

namespace MauticApiClient.Net
{
    public interface IAssetsClient
    {
        Asset GetAsset(int id);

        List<Asset> ListAssets(ListAssetRequest request);

        void CreateAsset(string title, string storageLocation, string file);

        void Edit(string title, string storageLocation, string file, bool createifnotexist = false);

        void DeleteAsset(int id);
    }
}
