using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class ALQuran : Base
    {
       ReusableMethods R;

        public ALQuran(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }


        //Method to perform action on Surah 1 using Locators
        public void QuranMajeedModule()
        {
            //  ReusableMethods.SplashHandling2ndsessiont();
            ReusableMethods.Click(Driver!, ALQuranMenu!, "Menu from Home Screen", test); 
            ReusableMethods.Click(Driver!, AlFatiha!, "Surah Al-Fatiha", test);
            Thread.Sleep(1000);
            Driver!.Navigate().Back();
            Thread.Sleep(1000);
            ReusableMethods.Click(Driver, Surah2!, "Surah 2", test);
            Driver.Navigate().Back();

        }
    

   

        //Element Locator for Surah Location
        IWebElement? ALQuranMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        //Web Elements
        IWebElement? AlFatiha => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement? PlaySurah => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play");
        IWebElement? Surah2 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName\" and @text=\"Surat Al-Baqara\"]");
    }
}
