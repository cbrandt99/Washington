using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WashingtonChameleons
{
    public class ChameleonUtils
    {

        public static Dictionary<int, string> markerColors = new Dictionary<int, string>() {

            {1, "#0000FF"},
            {2, "#008000"},
            {3, "#FFFF00"},
            {4, "#FFA500"},
            {5, "#FF0000"}

        };

        public static Dictionary<int, string> confidenceCriteria = new Dictionary<int, string>()
        {

            {1, "Company has the same address listed."},
            {2, "Company was established at the same location within the same year." },
            {3, "Company was established at the same location within six months." },
            {4, "Company was established at the same location within three months." },
            {5, "Company was established at the same location within the same month." }

        };

    }
}
