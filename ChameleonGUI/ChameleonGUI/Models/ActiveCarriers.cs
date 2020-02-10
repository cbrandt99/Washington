using System;
using System.Collections.Generic;

namespace ChameleonGUI.Models
{
    public partial class ActiveCarriers
    {
        public int DotNumber { get; set; }
        public string LegalName { get; set; }
        public string Dbaname { get; set; }
        public string CarrierOperation { get; set; }
        public string Hmflag { get; set; }
        public string Pcflag { get; set; }
        public string Phystreet { get; set; }
        public string Phycity { get; set; }
        public string Phystate { get; set; }
        public string Phyzip { get; set; }
        public string Phycountry { get; set; }
        public string MailingStreet { get; set; }
        public string MailingCity { get; set; }
        public string MainlingState { get; set; }
        public string MailingZip { get; set; }
        public string MailingCountry { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? Mcs150date { get; set; }
        public string Mcs150mileage { get; set; }
        public int? Mcs150mileageYear { get; set; }
        public DateTime? AddDate { get; set; }
        public string Oicstate { get; set; }
        public string NbrpowerUnit { get; set; }
        public string DriverTotal { get; set; }
    }
}
