using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WashingtonChameleons.Models
{
    public partial class MapMarker
    {

        public string CurrentName { get; set; }
        public string FormerName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? color { get; set; }

        public string controller { get; set; }
        public string action { get; set; }
        public int? index { get; set; }

        public string getURL()
        {
            return controller + "/" + action + "/" + index;
        }

        public MapMarker(string name, string latitude, string longitude, int? index)
        {

            this.CurrentName = name;
            this.FormerName = "";
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.color = 0;

            controller = "ActiveCarriers";
            action = "Details";
            this.index = index;

        }


        public MapMarker(string curName, string formerName, string latitude, string longitude, int? color, int? index)
        {

            this.CurrentName = curName;
            this.FormerName = formerName;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.color = color;

            controller = "Chameleon";
            action = "Details";
            this.index = index;

        }

    }
}
