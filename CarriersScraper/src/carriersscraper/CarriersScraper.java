
package carriersscraper;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import java.net.URLConnection;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.util.List;
import java.util.concurrent.TimeUnit;
import org.json.JSONArray;
import org.json.JSONObject;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;

public class CarriersScraper {
    
static WebDriver driver;


    public static void main(String[] args) 
    {
        String mySqlUrl = "jdbc:sqlserver://cameronserver.database.windows.net:1433;database=Washington;user=cameron@cameronserver;password=C@meronS;encrypt=true;trustServerCertificate=false;hostNameInCertificate=*.database.windows.net;loginTimeout=30;";
        Connection sqlConnect;
        String Json = "";
        String lat = "";
        String lng = "";
        String next_record = null;
        BufferedReader reader;
        URLConnection sock;
        
        //hold results pulled in from each row
        String[] queryArray = new String[6]; 
        
        //holds US Dot Number for inserting into sql
        int dotNumber;
        
        //holds number needed to increment xpath index
        int xpathCount = 1;
        
        //WebDriver set up and connection
        System.setProperty("webdriver.chrome.driver", 
                "C:\\Users\\hines\\OneDrive\\Documents\\Design and Testing\\Selenium\\selenium-java-3.141.59\\chromedriver.exe");
        System.out.println("Test initiated");
        ChromeOptions options = new ChromeOptions();
        options.addArguments("headless");
        options.addArguments("window-size=1920x1080");
        driver = new ChromeDriver(options);
        driver.get("https://li-public.fmcsa.dot.gov/LIVIEW/pkg_oos_process.prc_list?pv_vpath=LIVIEW&pv_show_all=N&pn_dotno=&pn_docket=&pv_legalname=&s_state=WAUS");
        
        //Intentionally waits 5 seconds after loading page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        
        //Create element for table, then a list of WebElements from that table
        WebElement carrierTable = driver.findElement(By.xpath("/html/body/font/table[2]"));
        List<WebElement> rows = carrierTable.findElements(By.tagName("tr"));

        //try catch for jdbc/Azure connection
        try{
            //Class.forName("com.mysql.jdbc.Driver");
            sqlConnect = DriverManager.getConnection(mySqlUrl);
            
            //loop iterates through the table grabbing dot number, and saving the columns of tables in list
            for(int x = 0; x < rows.size(); x++)
            {    
                WebElement usDots = rows.get(x).findElement(By.xpath("/html/body/font/table[2]/tbody/tr["  + (xpathCount) + "]/th"));
                List<WebElement> cols = rows.get(x).findElements(By.tagName("td"));

                //loop stores each cell from rows in String array
                for(int y = 0; y < cols.size(); y++)
                {
                    queryArray[y] = cols.get(y).getText();
                }
                
                //If statement to ignore top table header and prepare sql insert
                if (x > 0) {
                    Json = "";
                    
                    //Grabs address that is scraped
                    String urlAddress = queryArray[1];
                    
                    //Formats address to remove whitespace, new lines, and comma
                    int commaIndex = urlAddress.indexOf(',');
                    urlAddress = urlAddress.substring(0, commaIndex - 1);
                    urlAddress = urlAddress.replaceAll("\n", " ");
                    urlAddress = urlAddress.replace(" ", "%20");
                    
                    //Concatenated string for api URL and connection
                    URL url = new URL("http://www.mapquestapi.com/geocoding/v1/address?key=4LLKm5hPuvURO3ExzjBRda2Dp90Z3fv4&location=" + urlAddress);
                    sock = url.openConnection();
                    
                    //reads in each line of JSON and saves it as string
                    reader = new BufferedReader(new InputStreamReader(sock.getInputStream()));
                    while ((next_record = reader.readLine()) != null) {
                        Json += next_record;
                    }
                    
                    //works through the JSON parsing out latitude and longitude
                    JSONObject obj = new JSONObject(Json);
                    JSONArray results = obj.optJSONArray("results");
                    if (results != null) {
                        for (int i = 0; i < results.length(); i++) {
                            JSONObject objAtIndex = results.optJSONObject(i);
                            if (objAtIndex != null) {
                                JSONArray locations = objAtIndex.optJSONArray("locations");
                                for (int j = 0; j < locations.length(); j++) {
                                    JSONObject thing = locations.getJSONObject(j);
                                    lat = Double.toString(thing.getJSONObject("latLng").getDouble("lat"));
                                    lng = Double.toString(thing.getJSONObject("latLng").getDouble("lng"));
                                }
                            }
                        }

                    }
                    reader.close();
                    
                    //prepares statement for execution to database
                    queryArray[5] = usDots.getText();
                    String query = " insert into Carriers (DotNumber, CarrierName, Address, OOS_Reason, OOS_Date, Status, Latitude, Longitude)"
                            + " values (?, ?, ?, ?, ?, ?, ?, ?)";
                    dotNumber = Integer.parseInt(queryArray[5].trim());
                    PreparedStatement preparedStmt = sqlConnect.prepareStatement(query);
                    preparedStmt.setInt(1, dotNumber);
                    preparedStmt.setString(2, queryArray[0]);
                    preparedStmt.setString(3, queryArray[1]);
                    preparedStmt.setString(4, queryArray[2]);
                    preparedStmt.setString(5, queryArray[3]);
                    preparedStmt.setString(6, queryArray[4]);
                    preparedStmt.setString(7, lat);
                    preparedStmt.setString(8, lng);

                    //executes sql insert statement to database
                    preparedStmt.execute();
                    System.out.println(x + " Records Saved");
                }

                //increments xpath count for index each iteration
                xpathCount++;
            }

        } catch (Exception ex) {
            System.out.println(ex);
            System.exit(1);
        }
    }
}
