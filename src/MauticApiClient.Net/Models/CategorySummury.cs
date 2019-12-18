namespace MauticApiClient.Net.Models
{
    public class CategorySummurys
    {
        /// <summary>
        /// ID of the category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The category title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The category alias
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// The category description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The category color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The bundle where the category will be available
        /// </summary>
        public string Bundle { get; set; }
    }
}
