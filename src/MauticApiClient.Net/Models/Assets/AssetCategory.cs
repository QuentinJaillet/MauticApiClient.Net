namespace MauticApiClient.Net.Models.Assets
{
    public class AssetCategory
    {
        public string createdByUser { get; set; }
        public string modifiedByUser { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string alias { get; set; }
        public object description { get; set; }
        public object color { get; set; }
        public string bundle { get; set; }
    }
}
