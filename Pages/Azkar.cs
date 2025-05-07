using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class Azkar : Base
    {
        ReusableMethods R;

        public Azkar(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
            R = new ReusableMethods(driver);
        }

        public void AzkarTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, azkarMenu, "Azkar Menu", test, softAssert);
            ReusableMethods.Click1(driver, Azkar_DuaSelection1, "Azkar Dua Selection - Upon waking up", test, softAssert);
            ReusableMethods.Click1(driver, AddtoBookmark, "Add to Bookmark", test, softAssert);
            driver.Navigate().Back();
            ReusableMethods.Click1(driver, BooksMarksButton, "Bookmarks Button", test, softAssert);

            // Uncomment these if ViewBookmark check is needed
            // ReusableMethods.Click1(driver, ViewBookmark, "View Bookmark - Upon waking up", test, softAssert);
            // driver.Navigate().Back();

            driver.Navigate().Back();
            driver.Navigate().Back();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By azkarMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivazkar");

        private By Azkar_DuaSelection1 => By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName' and @text='Upon waking up']");

        private By Azkar_DuaSelection2 => By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName' and @text='Before Undressing']");

        private By AddtoBookmark => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/button_star");

        private By ViewBookmark => By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName' and @text='Upon waking up']");

        private By BooksMarksButton => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/action_bookmarks");
    }
}
