using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BigDataGeocode
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Server=tcp:cameronserver.database.windows.net,1433;Initial Catalog=Washington;Persist Security Info=False;User ID=cameron;Password=C@meronS;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sql = "select * from active_carriers";
            connection = new SqlConnection(connetionString);
            List<Carrier> carrierList = new List<Carrier>();

            int startNum = 0;

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Carrier carrier = new Carrier(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(6), dataReader.GetValue(7), dataReader.GetValue(8));
                    carrierList.Add(carrier);
                }

                Carrier[] carrierArray = carrierList.ToArray();
                List<Geocode> locationInfo = new List<Geocode>();

                for (int i = startNum; i < carrierArray.Length; i++)
                {
                    Console.WriteLine(i + 1);

                    carrierArray[i].PHYStreet = carrierArray[i].PHYStreet.Replace("#", "");
                    carrierArray[i].PHYStreet = carrierArray[i].PHYStreet.Replace("&", "");
                    carrierArray[i].PHYStreet = carrierArray[i].PHYStreet.Replace(" NORTH", "");
                    carrierArray[i].PHYStreet = carrierArray[i].PHYStreet.Replace("NLAKE", "LAKE");

                    string json = "";

                    using (WebClient wc = new WebClient())
                    {
                        json = wc.DownloadString("https://geocoder.ls.hereapi.com/6.2/geocode.json?apiKey=hEjWJp5WMY9kqX8KpxnphwSELF_N0b5hqME5zRXzGnQ&searchtext=" + carrierArray[i].PHYStreet + "+" + carrierArray[i].PHYCity + "+" + carrierArray[i].PHYState);
                    }

                    locationInfo.Add(JsonConvert.DeserializeObject<Geocode>(json));
                }

                dataReader.Close();
                command.Dispose();

                Geocode[] locationInfoArray = locationInfo.ToArray();
                Console.WriteLine("Array Length: " + locationInfoArray.Length);

                for (int i = startNum; i < locationInfoArray.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(i + 1);
                    Console.WriteLine("Length: " + locationInfoArray[i].Response.View.Length);
                    Console.WriteLine(carrierArray[i].toString());

                    if (locationInfoArray[i].Response.View.Length != 0)
                    {
                        sql = "update active_carriers set Latitude = '" + locationInfoArray[i].Response.View[0].Result[0].Location.DisplayPosition.Latitude + "', Longitude='" + locationInfoArray[i].Response.View[0].Result[0].Location.DisplayPosition.Longitude + "' where Number =" + (i + 1);
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                    }
                }

                for (int i = startNum; i < locationInfoArray.Length; i++)
                {
                    if (locationInfoArray[i].Response.View.Length == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine(i + 1);
                        Console.WriteLine("Length: " + locationInfoArray[i].Response.View.Length);
                        Console.WriteLine(carrierArray[i].toString());
                    }
                }

                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex);
            }

            Console.WriteLine();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}