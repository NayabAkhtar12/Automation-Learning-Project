using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class PrayerTimes : Base
    {
       ReusableMethods R;

        public PrayerTimes(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void PrayerTimesTest()
        {
            ReusableMethods.Click(Driver!, prayerTimesMenu!, " prayerTimesMenu", test);
            ReusableMethods.Click(Driver!, PrayerTimeNotification!, " prayerTimesMenu", test);
            Thread.Sleep(3000);
            Driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement? PrayerTimeNotification => Driver?.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ib_notification\"])[3]");

        IWebElement? prayerTimesMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivprayers");

    }
}
