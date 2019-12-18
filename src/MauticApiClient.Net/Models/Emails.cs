using System.Collections.Generic;

namespace MauticApiClient.Net.Models
{
    public class Emails
    {
        public Emails()
        {
            Data = new List<Email>();
        }

        public int Total { get; set; }

        public List<Email> Data { get; set; }
    }
}
