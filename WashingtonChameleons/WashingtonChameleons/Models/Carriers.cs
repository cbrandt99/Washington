using System;
using System.Collections.Generic;

namespace WashingtonChameleons.Models
{
    public partial class Carriers
    {
        public int Number { get; set; }
        public int DotNumber { get; set; }
        public string CarrierName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateAddress { get; set; }
        public string Zipcode { get; set; }
        public string OosReason { get; set; }
        public string OosDate { get; set; }
        public string Status { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
