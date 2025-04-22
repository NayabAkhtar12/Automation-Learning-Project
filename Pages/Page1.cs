using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class Page1 : Base
    {
       ReusableMethods R;

        public Page1(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }


        //Method to perform action on Surah 1 using Locators
        public void QuranMajeedModule()
        {
            //  ReusableMethods.SplashHandling2ndsessiont();
            ReusableMethods.Click(driver!, ALQuranMenu!, "Menu from Home Screen", test); 
            test?.Info("Clicked Menu from Home Screen");
            ReusableMethods.Click(driver!, AlFatiha!, "Surah Al-Fatiha", test);
            Thread.Sleep(1000);
            test?.Info("Clicked Surah from list");
            driver!.Navigate().Back();
            Thread.Sleep(1000);
            ReusableMethods.Click(driver, Surah2!, "Surah 2", test);
            test?.Info("Clicked Surah from list");
            driver.Navigate().Back();

        }

       
        //Element Locator for Surah Location
        IWebElement? ALQuranMenu => driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        //Web Elements
        IWebElement? AlFatiha => driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement? PlaySurah => driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play");
        IWebElement? Surah2 => driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName\" and @text=\"Surat Al-Baqara\"]");
       // IWebElement? AIChatmenu => driver?.FindElementById("");
    }
}
