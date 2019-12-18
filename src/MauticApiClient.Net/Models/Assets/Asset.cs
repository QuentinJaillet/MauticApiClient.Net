using System;

namespace MauticApiClient.Net.Models.Assets
{
    public class Asset
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string alias { get; set; }
        public string language { get; set; }
        public bool isPublished { get; set; }
        public DateTime publishUp { get; set; }
        public DateTime publishDown { get; set; }
        public DateTime dateAdded { get; set; }
        public int createdBy { get; set; }
        public string createdByUser { get; set; }
        public string dateModified { get; set; }
        public int modifiedBy { get; set; }
        public string modifiedByUser { get; set; }
        public int downloadCount { get; set; }
        public int uniqueDownloadCount { get; set; }
        public int revision { get; set; }
        public AssetCategory category { get; set; }
        public string extension { get; set; }
        public string mime { get; set; }
        public int size { get; set; }
        public string downloadUrl { get; set; }
    }
}
