using Newtonsoft.Json;
using System.Collections.Generic;

namespace MauticApiClient.Net.Model
{
    public class Categories
    {
        public int Total { get; set; }

        public IEnumerable<CategorySummury> Data { get; set; }
    }
}
