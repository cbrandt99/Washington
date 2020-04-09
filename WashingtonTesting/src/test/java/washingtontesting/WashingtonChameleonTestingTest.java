package washingtontesting;

import java.util.List;
import java.util.concurrent.TimeUnit;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;

import org.junit.AfterClass;
import org.junit.BeforeClass;
import org.junit.Ignore;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class WashingtonChameleonTestingTest {
    
    static WebDriver driver;

    @BeforeClass
    public static void SetupTest() {
        System.setProperty("webdriver.chrome.driver",
                "E:\\WebDriver\\chromedriver.exe");
        System.out.println("Test initiated");
        driver = new ChromeDriver(new ChromeOptions().addArguments("--headless"));
        driver.get("https://washingtonchameleons.azurewebsites.net");
    }

    @AfterClass
    public static void EndTest() {
        driver.close();
    }
    
    //All Tests Succeed - 4-8-20
    

    //Tests each NAV button, making sure each one leads to the correct page of the website
    //Final Test Passed 4-8-20
    @Test
    public void TestNavButtons() 
    {
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        
        //Expected headings from each page
        String expectedHeadingHome = "Washington Chameleon Companies";
        String expectedHeadingPotential = "Potential Chameleon Companies";
        String expectedHeadingActive = "Active Carriers";
        String expectedHeadingChameleon = "Washington Chameleon Companies";
        
        //Home button test
        WebElement homeButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[1]/a"));
        homeButton.click();
        WebElement homeHeading =  driver.findElement(By.className("display-4"));
        assertEquals(expectedHeadingHome, homeHeading.getText());
        
        //Potential chameleons button test
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        WebElement potentialHeading =  driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/h1"));
        assertEquals(expectedHeadingPotential, potentialHeading.getText());
        
        //Active carriers button test
        WebElement activeButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[3]/a"));
        activeButton.click();
        WebElement activeHeading =  driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/h1"));
        assertEquals(expectedHeadingActive, activeHeading.getText());
        
        //Washington chameleon button test
        WebElement chameleonButton = driver.findElement(By.xpath("/html/body/header/nav/div/a"));
        chameleonButton.click();
        WebElement chameleonHeading =  driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/h1"));
        assertEquals(expectedHeadingChameleon, chameleonHeading.getText());  
    }
    
    //Test that the view changes when clicked grid or table layout
    //Final Test Passed 4-8-20
    @Test
    public void TestGridAndTableLayout()
    {
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        
        //expected tags for each layout
        String expectedGridTag = "div";
        String expectedTableTag = "tr";
        
        //Navigate to correct page
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Switch To Grid View
        WebElement gridButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/div/button[2]"));
        gridButton.click();
        
        //Grid tests
        WebElement firstGridPiece = driver.findElement(By.xpath("/html/body/div[1]/main/div[3]/div/div[1]"));
        assertEquals(expectedGridTag, firstGridPiece.getTagName());
        
        WebElement secondGridPiece = driver.findElement(By.xpath("/html/body/div[1]/main/div[3]/div/div[5]"));
        assertEquals(expectedGridTag, secondGridPiece.getTagName());
        
        WebElement thirdGridPiece = driver.findElement(By.xpath("/html/body/div[1]/main/div[3]/div/div[9]"));
        assertEquals(expectedGridTag, thirdGridPiece.getTagName());
        
        //Switch back to table view
        WebElement tableButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/div/button[1]"));
        tableButton.click();
        
        //Table tests
        WebElement firstTablePiece = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[1]"));
        assertEquals(expectedTableTag, firstTablePiece.getTagName());
        
        WebElement secondTablePiece = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[2]"));
        assertEquals(expectedTableTag, secondTablePiece.getTagName());
        
        WebElement thirdTablePiece = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[3]"));
        assertEquals(expectedTableTag, thirdTablePiece.getTagName());  
    }
    
    //Test functionality of searching for specific potential chameleon companies
    //Final Test Passed 4-8-20
    @Test
    public void TestPotentialPageSearchBar()
    {
        //Expected results of search
        String[] expectedCurrentNameArray = {"A&A CARRIER LLC","DAS EXPRESS LLC","KUZBASS LOGISTICS LLC"};
        String[] expectedFormerNameArray = {"PAC WEST TRANSPORT LLC", "EXPRESS GROUP INC", "ANDREY NIKONOV NIKON"};
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //search bar and search button
        WebElement searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        
        //First Search
        searchBar.click();
        searchBar.sendKeys("A&A CARRIER LLC");
        searchButton.click();
        WebElement currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        WebElement formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        assertEquals(expectedCurrentNameArray[0], currentName.getText());
        assertEquals(expectedFormerNameArray[0], formerName.getText());
        
        //Second Search
        searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchBar.click();
        searchBar.sendKeys("DAS EXPRESS LLC");
        searchButton.click();
        currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        assertEquals(expectedCurrentNameArray[1], currentName.getText());
        assertEquals(expectedFormerNameArray[1], formerName.getText());
        
        //Third Search
        searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchBar.click();
        searchBar.sendKeys("KUZBASS LOGISTICS LLC");
        searchButton.click();
        currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        assertEquals(expectedCurrentNameArray[2], currentName.getText());
        assertEquals(expectedFormerNameArray[2], formerName.getText());
    }
    
    //Tests confidence level one to see if values returned are equal to or greater
    //Final Test Passed 4-8-20
    @Test
    public void TestConfidenceOneSearch()
    {
        //tr count to grab each span
        int count = 0;
        
        //Boolean to check next is available for another set of data
        boolean nextClickable = true;
        
        //Expected confidence value
        int expectedConfidenceValue = 1;
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click confidence one (blue square) and click search
        WebElement confidenceOne = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/a[1]"));
        confidenceOne.click();
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchButton.click();
        
        
        //Loops through each row in table checking the amount of confidence level indicators are displayed, and clicks next button until it is unavailable
        while(nextClickable == true)
        {
            WebElement nextButton = new WebDriverWait(driver, 30).until(ExpectedConditions.elementToBeClickable(By.xpath("/html/body/div[1]/main/div[4]/a[2]")));
            WebElement table = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody"));
            List<WebElement> rows = table.findElements(By.tagName("tr"));

            //loops through each row grabbing the span and getting the amount of 'i' tags inside, number of tags indicates amount of squares for level
            for(WebElement row : rows)
            {
                count++;
                WebElement span = row.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[" + count + "]/td[9]/span"));
                List<WebElement> iTags = span.findElements(By.tagName("i"));
                assertTrue("Confidence Level Does Not Match Searched Value", iTags.size() >= expectedConfidenceValue);
            }
            count = 0;
            
            //checks next button is enabled
            if(nextButton.getAttribute("class").equals("btn btn-primary disabled"))
            {
                nextClickable = false;
            }
            else
            {
                nextButton.click();
            }
        }
    }
    
    //Tests confidence level two to see if values returned are equal to or greater
    //Final Test Passed 4-8-20
    @Test
    public void TestConfidenceTwoSearch()
    {
        //tr count to grab each span
        int count = 0;
        
        //Boolean to check next is available for another set of data
        boolean nextClickable = true;
        
        //Expected confidence value
        int expectedConfidenceValue = 2;
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click confidence two (green squares) and click search
        WebElement confidenceTwo = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/a[2]"));
        confidenceTwo.click();
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchButton.click();
        
        //Loops through each row in table checking the amount of confidence level indicators are displayed, and clicks next button until it is unavailable
        while(nextClickable == true)
        {
            WebElement nextButton = new WebDriverWait(driver, 30).until(ExpectedConditions.elementToBeClickable(By.xpath("/html/body/div[1]/main/div[4]/a[2]")));
            WebElement table = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody"));
            List<WebElement> rows = table.findElements(By.tagName("tr"));

            //loops through each row grabbing the span and getting the amount of 'i' tags inside, number of tags indicates amount of squares for level
            for(WebElement row : rows)
            {
                count++;
                WebElement span = row.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[" + count + "]/td[9]/span"));
                List<WebElement> iTags = span.findElements(By.tagName("i"));
                assertTrue("Confidence Level Does Not Match Searched Value", iTags.size() >= expectedConfidenceValue);
            }
            count = 0;
            
            //checks next button is enabled
            if(nextButton.getAttribute("class").equals("btn btn-primary disabled"))
            {
                nextClickable = false;
            }
            else
            {
                nextButton.click();
            }
        }
    }
    
    //Tests confidence level three to see if values returned are equal to or greater
    //Final Test Passed 4-8-20
    @Test
    public void TestConfidenceThreeSearch()
    {
        //tr count to grab each span
        int count = 0;
        
        //Boolean to check next is available for another set of data
        boolean nextClickable = true;
        
        //Expected confidence value
        int expectedConfidenceValue = 3;
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click confidence three (yellow squares) and click search
        WebElement confidenceThree = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/a[3]"));
        confidenceThree.click();
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchButton.click();
        
        //Loops through each row in table checking the amount of confidence level indicators are displayed, and clicks next button until it is unavailable
        while(nextClickable == true)
        {
            WebElement nextButton = new WebDriverWait(driver, 30).until(ExpectedConditions.elementToBeClickable(By.xpath("/html/body/div[1]/main/div[4]/a[2]")));
            WebElement table = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody"));
            List<WebElement> rows = table.findElements(By.tagName("tr"));

            //loops through each row grabbing the span and getting the amount of 'i' tags inside, number of tags indicates amount of squares for level
            for(WebElement row : rows)
            {
                count++;
                WebElement span = row.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[" + count + "]/td[9]/span"));
                List<WebElement> iTags = span.findElements(By.tagName("i"));
                assertTrue("Confidence Level Does Not Match Searched Value", iTags.size() >= expectedConfidenceValue);
            }
            count = 0;
            
            //checks next button is enabled
            if(nextButton.getAttribute("class").equals("btn btn-primary disabled"))
            {
                nextClickable = false;
            }
            else
            {
                nextButton.click();
            }
        }
    }
    
    //Tests confidence level four to see if values returned are equal to or greater
    //Final Test Passed 4-8-20
    @Test
    public void TestConfidenceFourSearch()
    {
        //tr count to grab each span
        int count = 0;
        
        //Boolean to check next is available for another set of data
        boolean nextClickable = true;
        
        //Expected confidence value
        int expectedConfidenceValue = 4;
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click confidence four (orange squares) and click search
        WebElement confidenceFour = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/a[4]"));
        confidenceFour.click();
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchButton.click();
        
        //Loops through each row in table checking the amount of confidence level indicators are displayed, and clicks next button until it is unavailable
        while(nextClickable == true)
        {
            WebElement nextButton = new WebDriverWait(driver, 30).until(ExpectedConditions.elementToBeClickable(By.xpath("/html/body/div[1]/main/div[4]/a[2]")));
            WebElement table = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody"));
            List<WebElement> rows = table.findElements(By.tagName("tr"));

            //loops through each row grabbing the span and getting the amount of 'i' tags inside, number of tags indicates amount of squares for level
            for(WebElement row : rows)
            {
                count++;
                WebElement span = row.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[" + count + "]/td[9]/span"));
                List<WebElement> iTags = span.findElements(By.tagName("i"));
                assertTrue("Confidence Level Does Not Match Searched Value", iTags.size() >= expectedConfidenceValue);
            }
            count = 0;
            
            //checks next button is enabled
            if(nextButton.getAttribute("class").equals("btn btn-primary disabled"))
            {
                nextClickable = false;
            }
            else
            {
                nextButton.click();
            }
        }
    }
    
    //Tests confidence level four to see if values returned are equal to or greater
    //Final Test Passed 4-8-20
    @Test
    public void TestConfidenceFiveSearch()
    {
        //tr count to grab each span
        int count = 0;
        
        //Boolean to check next is available for another set of data
        boolean nextClickable = true;
        
        //Expected confidence value
        int expectedConfidenceValue = 5;
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click confidence five (red squares) and click search
        WebElement confidenceFive = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/a[5]"));
        confidenceFive.click();
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchButton.click();
        
        //Loops through each row in table checking the amount of confidence level indicators are displayed, and clicks next button until it is unavailable
        while(nextClickable == true)
        {
            WebElement nextButton = new WebDriverWait(driver, 30).until(ExpectedConditions.elementToBeClickable(By.xpath("/html/body/div[1]/main/div[4]/a[2]")));
            WebElement table = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody"));
            List<WebElement> rows = table.findElements(By.tagName("tr"));

            //loops through each row grabbing the span and getting the amount of 'i' tags inside, number of tags indicates amount of squares for level
            for(WebElement row : rows)
            {
                count++;
                WebElement span = row.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[" + count + "]/td[9]/span"));
                List<WebElement> iTags = span.findElements(By.tagName("i"));
                assertTrue("Confidence Level Does Not Match Searched Value", iTags.size() == expectedConfidenceValue);
            }
            count = 0;
            
            //checks next button is enabled
            if(nextButton.getAttribute("class").equals("btn btn-primary disabled"))
            {
                nextClickable = false;
            }
            else
            {
                nextButton.click();
            }
        }
    }
    
    //Test details button shows correct information on potential chameleon companies page (First record)
    //Final Test Passed 4-8-20
    @Test
    public void testPotentialDetailsButtonOne()
    {
        //Expected information
        String expectedCurrentName = "A&A CARRIER LLC";
        String expectedFormerName = "PAC WEST TRANSPORT LLC";
        String expectedDateRegistered = "9/26/2018";
        String expectedStreetAddress = "18221 168TH WAY SE";
        String expectedCity = "RENTON";
        String expectedState = "WA";
        String expectedZipcode = "98058";
        
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click details button
        WebElement detailsButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[1]/td[10]/a"));
        detailsButton.click();
        
        //Check current name
        WebElement currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[2]"));
        assertEquals(expectedCurrentName, currentName.getText());
        
        //Check former name
        WebElement formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[2]/tbody/tr/td[2]"));
        assertEquals(expectedFormerName, formerName.getText());
        
        //Check date registered
        WebElement dateRegistered = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[4]"));
        assertEquals(expectedDateRegistered, dateRegistered.getText());
        
        //Split address to compare with expected values
        String fullAddress = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[3]")).getText();
        int firstComma = fullAddress.indexOf(",");
        int secondComma = fullAddress.indexOf(",", fullAddress.indexOf(",") + 1);
        String streetAddress = fullAddress.substring(0, firstComma);
        String city = fullAddress.substring(firstComma + 2, secondComma);
        String state = fullAddress. substring(secondComma + 2, secondComma + 4);
        String zipcode = fullAddress.substring(secondComma + 5, fullAddress.length());

        //Check street address
        assertEquals(expectedStreetAddress, streetAddress);
        
        //Check city
        assertEquals(expectedCity, city);
        
        //Check state
        assertEquals(expectedState, state);
        
        //Check zipcode
        assertEquals(expectedZipcode, zipcode);
    }
    
    //Test details button shows correct information on potential chameleon companies page (Second record)
    //Final Test Passed 4-8-20
    @Test
    public void testPotentialDetailsButtonTwo()
    {
        //Expected information
        String expectedCurrentName = "DAS EXPRESS LLC";
        String expectedFormerName = "EXPRESS GROUP INC";
        String expectedDateRegistered = "6/24/2015";
        String expectedStreetAddress = "6721 MONTEVISTA DR SE";
        String expectedCity = "AUBURN";
        String expectedState = "WA";
        String expectedZipcode = "98092";
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement potentialButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[2]/a"));
        potentialButton.click();
        
        //Click next button
        WebElement nextButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[4]/a[2]"));
        nextButton.click();
        
        //Click details button
        WebElement detailsButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[4]/td[10]/a"));
        detailsButton.click();
        
        //Check current name
        WebElement currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[2]"));
        assertEquals(expectedCurrentName, currentName.getText());
        
        //Check former name
        WebElement formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[2]/tbody/tr/td[2]"));
        assertEquals(expectedFormerName, formerName.getText());
        
        //Check date registered
        WebElement dateRegistered = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[4]"));
        assertEquals(expectedDateRegistered, dateRegistered.getText());
        
        //Split address to compare with expected values
        String fullAddress = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[3]")).getText();
        int firstComma = fullAddress.indexOf(",");
        int secondComma = fullAddress.indexOf(",", fullAddress.indexOf(",") + 1);
        String streetAddress = fullAddress.substring(0, firstComma);
        String city = fullAddress.substring(firstComma + 2, secondComma);
        String state = fullAddress. substring(secondComma + 2, secondComma + 4);
        String zipcode = fullAddress.substring(secondComma + 5, fullAddress.length());

        //Check street address
        assertEquals(expectedStreetAddress, streetAddress);
        
        //Check city
        assertEquals(expectedCity, city);
        
        //Check state
        assertEquals(expectedState, state);
        
        //Check zipcode
        assertEquals(expectedZipcode, zipcode);
    }
    
    //Test functionality of searching for specific active carriers
    //Final Test Passed 4-8-20
    @Test
    public void TestActivePageSearchBar()
    {
        //Expected results of search
        String[] expectedNameArray = {"ALASKA LOGISTICS LLC", "BLANCO TOWING LLC", "SJM CONSTRUCTION INC"};
        String[] expectedAddressArray = {"7421 5TH AVE SOUTH", "27400 132ND AVE SE APT A108", "7021 44TH AVE E"};
        String[] expectedCityArray = {"SEATTLE", "KENT", "TACOMA"};
        String[] expectedStateArray = {"WA", "WA", "WA"};
        String[] expectedZipcodeArray = {"98108", "98042", "98443"};
        String[] expectedPhoneNumberArray = {"(206) 767-2555", "(253) 394-6937", "(253) 381-4188"};
        String[] expectedEmailArray = {"ALLYN@ALASKA-LOGISTICS.COM", "LEOBLANCO522@GMAIL.COM", ""};
        String[] expectedDateAddedArray = {"5/12/2008", "3/6/2019", "6/24/2009"};
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement activeButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[3]/a"));
        activeButton.click();
        
        //search bar and search button
        WebElement searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        
        //First Search
        searchBar.click();
        searchBar.sendKeys("ALASKA LOGISTICS LLC");
        searchButton.click();
        WebElement name = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        WebElement address = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        WebElement city = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[3]"));
        WebElement state = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[4]"));
        WebElement zipcode = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[5]"));
        WebElement phoneNumber = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[6]"));
        WebElement email = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[7]"));
        WebElement dateAdded = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[8]"));
        
        //Check results
        assertEquals(expectedNameArray[0], name.getText());
        assertEquals(expectedAddressArray[0], address.getText());
        assertEquals(expectedCityArray[0], city.getText());
        assertEquals(expectedStateArray[0], state.getText());
        assertEquals(expectedZipcodeArray[0], zipcode.getText());
        assertEquals(expectedPhoneNumberArray[0], phoneNumber.getText());
        assertEquals(expectedEmailArray[0], email.getText());
        assertEquals(expectedDateAddedArray[0], dateAdded.getText());
        
        //Second Search
        searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchBar.click();
        searchBar.sendKeys("BLANCO TOWING LLC");
        searchButton.click();
        name = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        address = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        city = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[3]"));
        state = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[4]"));
        zipcode = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[5]"));
        phoneNumber = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[6]"));
        email = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[7]"));
        dateAdded = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[8]"));
        
        //Check results
        assertEquals(expectedNameArray[1], name.getText());
        assertEquals(expectedAddressArray[1], address.getText());
        assertEquals(expectedCityArray[1], city.getText());
        assertEquals(expectedStateArray[1], state.getText());
        assertEquals(expectedZipcodeArray[1], zipcode.getText());
        assertEquals(expectedPhoneNumberArray[1], phoneNumber.getText());
        assertEquals(expectedEmailArray[1], email.getText());
        assertEquals(expectedDateAddedArray[1], dateAdded.getText());
        
        //Second Search
        searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchBar.click();
        searchBar.sendKeys("BLANCO TOWING LLC");
        searchButton.click();
        name = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        address = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        city = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[3]"));
        state = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[4]"));
        zipcode = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[5]"));
        phoneNumber = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[6]"));
        email = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[7]"));
        dateAdded = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[8]"));
        
        //Check results
        assertEquals(expectedNameArray[1], name.getText());
        assertEquals(expectedAddressArray[1], address.getText());
        assertEquals(expectedCityArray[1], city.getText());
        assertEquals(expectedStateArray[1], state.getText());
        assertEquals(expectedZipcodeArray[1], zipcode.getText());
        assertEquals(expectedPhoneNumberArray[1], phoneNumber.getText());
        assertEquals(expectedEmailArray[1], email.getText());
        assertEquals(expectedDateAddedArray[1], dateAdded.getText());

        //Third Search
        searchBar = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/input[1]"));
        searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/div/div/form/button"));
        searchBar.click();
        searchBar.sendKeys("SJM CONSTRUCTION INC");
        searchButton.click();
        name = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[1]"));
        address = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[2]"));
        city = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[3]"));
        state = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[4]"));
        zipcode = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[5]"));
        phoneNumber = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[6]"));
        email = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[7]"));
        dateAdded = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[8]"));
        
        //Check results
        assertEquals(expectedNameArray[2], name.getText());
        assertEquals(expectedAddressArray[2], address.getText());
        assertEquals(expectedCityArray[2], city.getText());
        assertEquals(expectedStateArray[2], state.getText());
        assertEquals(expectedZipcodeArray[2], zipcode.getText());
        assertEquals(expectedPhoneNumberArray[2], phoneNumber.getText());
        assertEquals(expectedEmailArray[2], email.getText());
        assertEquals(expectedDateAddedArray[2], dateAdded.getText());
    }
    
    //Test details button shows correct information on active carrier page (First record)
    //Final Test Passed 4-8-20
    @Test
    public void TestActiveDetailsButtonOne()
    {
        String expectedName = "0BERT MARINE SUPPLY INC";
        String expectedAddress = "3441 2ND AVE SOUTH";
        String expectedCity = "SEATTLE";
        String expectedState = "WA";
        String expectedZipcode = "98134";
        String expectedPhoneNumber = "(206) 623-7822";
        String expectedDateRegistered = "8/8/2009";
        
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement activeButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[3]/a"));
        activeButton.click();
        
        //Click details button
        WebElement detailsButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr/td[9]/a"));
        detailsButton.click();
        
        //Split address to compare with expected values
        String fullAddress = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[3]")).getText();
        int firstComma = fullAddress.indexOf(",");
        int secondComma = fullAddress.indexOf(",", fullAddress.indexOf(",") + 1);
        String streetAddress = fullAddress.substring(0, firstComma);
        String city = fullAddress.substring(firstComma + 2, secondComma);
        String state = fullAddress. substring(secondComma + 2, secondComma + 4);
        String zipcode = fullAddress.substring(secondComma + 5, fullAddress.length());
        
        WebElement name = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[2]"));
        WebElement phoneNumber = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[5]"));
        WebElement dateRegistered = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[4]"));
        
        //Check results
        assertEquals(expectedName, name.getText());
        assertEquals(expectedAddress, streetAddress);
        assertEquals(expectedCity, city);
        assertEquals(expectedState, state);
        assertEquals(expectedZipcode, zipcode);
        assertEquals(expectedPhoneNumber, phoneNumber.getText());
        assertEquals(expectedDateRegistered, dateRegistered.getText());
    }
    
    //Test details button shows correct information on active carrier page (Second record)
    //Final Test Passed 4-8-20
    @Test
    public void TestActiveDetailsButtonTwo()
    {
        String expectedName = "OCEAN EXPRESS TRANSPORTATION AND EQUIPMENT LLC";
        String expectedAddress = "1804 N NYHUS ST";
        String expectedCity = "WESTPORT";
        String expectedState = "WA";
        String expectedZipcode = "98595";
        String expectedPhoneNumber = "(360) 538-7400\nSWATSON@OCEANCOS.COM";
        String expectedDateRegistered = "1/27/2010";
        
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        driver.get("https://washingtonchameleons.azurewebsites.net/ActiveCarriers?pageNumber=526");
        
        //Click details button
        WebElement detailsButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/table/tbody/tr[9]/td[9]/a"));
        detailsButton.click();
        
        //Split address to compare with expected values
        String fullAddress = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[3]")).getText();
        int firstComma = fullAddress.indexOf(",");
        int secondComma = fullAddress.indexOf(",", fullAddress.indexOf(",") + 1);
        String streetAddress = fullAddress.substring(0, firstComma);
        String city = fullAddress.substring(firstComma + 2, secondComma);
        String state = fullAddress. substring(secondComma + 2, secondComma + 4);
        String zipcode = fullAddress.substring(secondComma + 5, fullAddress.length());
        
        WebElement name = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[2]"));
        WebElement phoneNumber = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[5]"));
        WebElement dateRegistered = driver.findElement(By.xpath("/html/body/div[1]/main/div/table/tbody/tr[1]/td[4]"));
        
        //Check results
        assertEquals(expectedName, name.getText());
        assertEquals(expectedAddress, streetAddress);
        assertEquals(expectedCity, city);
        assertEquals(expectedState, state);
        assertEquals(expectedZipcode, zipcode);
        assertEquals(expectedPhoneNumber, phoneNumber.getText());
        assertEquals(expectedDateRegistered, dateRegistered.getText());
    }
    
    //Tests searching zipcode to find chameleon company
    //Final Test Passed 4-8-20
    @Test
    public void TestChameleonZipCodeSearchOne()
    {
        //Expected values
        String expectedCurrentName = "A&A CARRIER LLC";
        String expectedFormerName = "PAC WEST TRANSPORT LLC";
        String expectedRegisteredDate = "9/26/2018";
        String expectedOutOfServiceDate = "12/3/2016";
        String expectedStreetAddress = "18221 168TH WAY SE";
        String expectedCity = "RENTON";
        String expectedState = "WA";
        String expectedZipcode = "98058";
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement activeButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[1]/a"));
        activeButton.click();
        
        //Enter zipcode and search
        WebElement zipcodeInput = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/form/input[1]"));
        zipcodeInput.click();
        zipcodeInput.sendKeys("98058");
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/form/button"));
        searchButton.click();
        
        //Click chameleon company
        WebElement blipButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/div/div[1]/div[4]/div[1]/img"));
        JavascriptExecutor executor = (JavascriptExecutor)driver;
        executor.executeScript("arguments[0].click();", blipButton);
        
        //Split address to compare with expected values
        String fullAddress = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[3]")).getText();
        int firstComma = fullAddress.indexOf(",");
        int secondComma = fullAddress.indexOf(",", fullAddress.indexOf(",") + 1);
        String streetAddress = fullAddress.substring(0, firstComma);
        String city = fullAddress.substring(firstComma + 2, secondComma);
        String state = fullAddress. substring(secondComma + 2, secondComma + 4);
        String zipcode = fullAddress.substring(secondComma + 5, fullAddress.length());
        
        WebElement currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[2]"));
        WebElement formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[2]/tbody/tr/td[2]"));
        WebElement registeredDate = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[4]"));
        WebElement outOfServiceDate = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[2]/tbody/tr/td[4]"));
        
        assertEquals(expectedCurrentName, currentName.getText());
        assertEquals(expectedFormerName, formerName.getText());
        assertEquals(expectedRegisteredDate, registeredDate.getText());
        assertEquals(expectedOutOfServiceDate, outOfServiceDate.getText());
        assertEquals(expectedStreetAddress, streetAddress);
        assertEquals(expectedCity, city);
        assertEquals(expectedState, state);
        assertEquals(expectedZipcode, zipcode);
    }
    
    //Tests searching zipcode to find chameleon company
    //Final Test Passed 4-8-20
    @Test
    public void TestChameleonZipCodeSearchTwo()
    {
        //Expected values
        String expectedCurrentName = "JEFF MILLER LOGGING LLC";
        String expectedFormerName = "JEFF MILLER";
        String expectedRegisteredDate = "11/8/2019";
        String expectedOutOfServiceDate = "3/5/2018";
        String expectedStreetAddress = "527 MARY ANN CREEK RD ";
        String expectedCity = "OROVILLE";
        String expectedState = "WA";
        String expectedZipcode = "98844";
        
        //Navigate to correct page
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
        WebElement activeButton = driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[1]/a"));
        activeButton.click();
        
        //Enter zipcode and search
        WebElement zipcodeInput = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/form/input[1]"));
        zipcodeInput.click();
        zipcodeInput.sendKeys("98844");
        WebElement searchButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/form/button"));
        searchButton.click();
        
        //Click chameleon company
        WebElement blipButton = driver.findElement(By.xpath("/html/body/div[1]/main/div[2]/div/div[1]/div[4]/div[1]/img"));
        JavascriptExecutor executor = (JavascriptExecutor)driver;
        executor.executeScript("arguments[0].click();", blipButton);
        
        //Split address to compare with expected values
        String fullAddress = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[3]")).getText();
        int firstComma = fullAddress.indexOf(",");
        int secondComma = fullAddress.indexOf(",", fullAddress.indexOf(",") + 1);
        String streetAddress = fullAddress.substring(0, firstComma);
        String city = fullAddress.substring(firstComma + 2, secondComma);
        String state = fullAddress. substring(secondComma + 2, secondComma + 4);
        String zipcode = fullAddress.substring(secondComma + 5, fullAddress.length());
        
        WebElement currentName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[2]"));
        WebElement formerName = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[2]/tbody/tr/td[2]"));
        WebElement registeredDate = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[1]/tbody/tr[1]/td[4]"));
        WebElement outOfServiceDate = driver.findElement(By.xpath("/html/body/div[1]/main/div[1]/table[2]/tbody/tr/td[4]"));
        
        assertEquals(expectedCurrentName, currentName.getText());
        assertEquals(expectedFormerName, formerName.getText());
        assertEquals(expectedRegisteredDate, registeredDate.getText());
        assertEquals(expectedOutOfServiceDate, outOfServiceDate.getText());
        assertEquals(expectedStreetAddress, streetAddress);
        assertEquals(expectedCity, city);
        assertEquals(expectedState, state);
        assertEquals(expectedZipcode, zipcode);
    }
}
