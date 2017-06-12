using System;

namespace MauticApiClient.Net.Model
{
    public class Category
    {
        /// <summary>
        /// ID of the category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Whether the category is published
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Date/time category was created
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// ID of the user that created the category
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Name of the user that created the category
        /// </summary>
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Date/time category was last modified
        /// </summary>
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// ID of the user that last modified the category
        /// </summary>
        public int ModifiedBy { get; set; }

        /// <summary>
        /// Name of the user that last modified the category
        /// </summary>
        public string ModifiedByUser { get; set; }

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
