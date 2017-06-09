using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MauticApiClient.Net.Model
{
    public class Contact
    {
        public int Id { get; set; }

        public DateTime? DateAdded { get; set; }

        public int CreatedBy { get; set; }

        [JsonProperty("createdByUser")]
        public string CreatedByUser { get; set; }

        public DateTime? DateModified { get; set; }

        public int ModifiedBy { get; set; }

        public string ModifiedByUser { get; set; }
        // todo  owner object User object that owns the contact.

        public int Points { get; set; }

        public DateTime? LastActive { get; set; }

        /// <summary>
        /// Date/time when the contact identified themselves
        /// </summary>
        public DateTime? DateIdentified { get; set; }

        /// <summary>
        /// Hex value given to contact from Point Trigger definitions based on the number of points the contact has been awarded
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Array of IPs currently associated with this contact
        /// </summary>
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Array of all contact fields with data grouped by field group. 
        /// See JSON code example for format.This array includes an “all” key that includes an single level array of fieldAlias => contactValue pairs.
        /// </summary>
        public List<string> Fields { get; set; }
    }
}
