using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDataGeocode
{
	class Carrier
	{
		public int DotNumber { get; set; }
		public string LegalName { get; set; }
		public string PHYStreet { get; set; }
		public string PHYCity { get; set; }
		public string PHYState { get; set; }

		public Carrier()
		{

		}

		public Carrier(object num, object name, object street, object city, object state)
		{
			DotNumber = Convert.ToInt32(num);
			LegalName = name.ToString();
			PHYStreet = street.ToString();
			PHYCity = city.ToString();
			PHYState = state.ToString();
		}

		public string toString()
		{
			return DotNumber + " " + LegalName + " Street: " + PHYStreet + " City: " + PHYCity + " State: " + PHYState;
		}
	}
}
