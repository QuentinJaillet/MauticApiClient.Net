namespace MauticApiClient.Net.Models.Assets
{
    public class ListAssetRequest
    {
        /// <summary>
        /// String or search command to filter entities by.
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Starting row for the entities returned. Defaults to 0.
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Limit number of entities to return. Defaults to the system configuration for pagination (30).
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Column to sort by. Can use any column listed in the response.
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// Sort direction: asc or desc.
        /// </summary>
        public string OrderByDir { get; set; }

        /// <summary>
        /// Only return currently published entities.
        /// </summary>
        public string PublishedOnly { get; set; }

        /// <summary>
        /// Return only array of entities without additional lists in it.
        /// </summary>
        public string Minimal { get; set; }
    }
}
