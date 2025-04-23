using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class Masjid : Base
    {
       ReusableMethods R;

        public Masjid(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void MasjidTest()
        {
            ReusableMethods.Click(Driver!, masjidFinderMenu!, " masjidFinderMenu", test);
            Thread.Sleep(5000);
            Driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement masjidFinderMenu => Driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid");

    }
}
