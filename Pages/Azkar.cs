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
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void AzkarTest()
        {
            ReusableMethods.Click(driver!, azkarMenu!, " azkarMenu", test);
            ReusableMethods.Click(driver!, Azkar_DuaSelection1!, "Select Azkar_DuaSelection1", test);
            ReusableMethods.Click(driver!, AddtoBookmark!, "Add to Bookmark", test);
            driver!.Navigate().Back();
            ReusableMethods.Click(driver!, BooksMarksButton!, "BooksMarksButton", test);
       //     ReusableMethods.Click(Driver!, ViewBookmark!, "CountTasbeeh", test);
        //    Driver!.Navigate().Back();
            driver!.Navigate().Back();
            driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement? azkarMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivazkar"));

        IWebElement? Azkar_DuaSelection1 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName' and @text='Upon waking up']"));

        IWebElement? Azkar_DuaSelection2 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName' and @text='Before Undressing']"));

        IWebElement? AddtoBookmark => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/button_star"));

        IWebElement? ViewBookmark => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName' and @text='Upon waking up']")); // Fixed: this was mistakenly using FindElementById

        IWebElement? BooksMarksButton => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/action_bookmarks"));
    }
}
