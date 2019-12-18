using Newtonsoft.Json;
using System.Collections.Generic;

namespace MauticApiClient.Net.Models
{
    public class Categories
    {
        public int Total { get; set; }

        public IEnumerable<Category> Data { get; set; }
    }
}