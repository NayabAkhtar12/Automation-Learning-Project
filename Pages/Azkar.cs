using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class Azkar : Base
    {
       ReusableMethods R;

        public Azkar(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void AzkarTest()
        {
            ReusableMethods.Click(Driver!, azkarMenu!, " azkarMenu", test);
            ReusableMethods.Click(Driver!, Azkar_DuaSelection1!, "Select Azkar_DuaSelection1", test);
            ReusableMethods.Click(Driver!, AddtoBookmark!, "Add to Bookmark", test);
            Driver!.Navigate().Back();
            ReusableMethods.Click(Driver!, BooksMarksButton!, "BooksMarksButton", test);
       //     ReusableMethods.Click(Driver!, ViewBookmark!, "CountTasbeeh", test);
        //    Driver!.Navigate().Back();
            Driver!.Navigate().Back();
            Driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement? azkarMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivazkar");
        IWebElement? Azkar_DuaSelection1 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Upon waking up\"]");
        IWebElement? Azkar_DuaSelection2 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Before Undressing\"]");
        IWebElement? AddtoBookmark => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/button_star");
        IWebElement? ViewBookmark => Driver?.FindElementById("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Upon waking up\"]");
        IWebElement? BooksMarksButton => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/action_bookmarks");

    }
}
