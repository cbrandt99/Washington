using System;
using System.Collections.Generic;

namespace ChameleonGUI.Models
{
    public partial class ChameleonTable
    {
        public string CurrentName { get; set; }
        public string FormerName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? DateOoS { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? ConfidenceLevel { get; set; }
        public int ChameleonId { get; set; }
    }
}
