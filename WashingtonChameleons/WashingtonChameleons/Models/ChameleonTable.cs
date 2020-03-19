using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WashingtonChameleons.Models
{
    public partial class ChameleonTable
    {
        [Display(Name = "Current Name")]
        public string CurrentName { get; set; }
        [Display(Name = "Former Name")]
        public string FormerName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Registered")]
        public DateTime? DateRegistered { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date OoS")]
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
