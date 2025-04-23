using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class QiblaFinder : Base
    {
       ReusableMethods R;

        public QiblaFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }


        public void QiblaFinderT()
        {
            ReusableMethods.Click(Driver!, QiblaFindermenu!, "Menu from Home Screen", test);
            ReusableMethods.Click(Driver!, SelectCompassMenu!, "SelectCompassMenu", test);
            ReusableMethods.Click(Driver!, Theme!, "Theme", test);
            Thread.Sleep(2000);
            Driver!.Navigate().Back();
            //Driver!.Navigate().Back();

        }

        //Element Locator for Surah Location
      
        IWebElement? QiblaFindermenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");
        IWebElement? SelectCompassMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement? Theme => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla3");
    }
}
