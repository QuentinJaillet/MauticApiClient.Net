using System.Collections.Generic;

namespace MauticApiClient.Net.Model
{
    public class Contacts
    {
        public Contacts()
        {
            Data = new List<Contact>();
        }

        public int Total { get; set; }

        public List<Contact> Data { get; set; }
    }
}
