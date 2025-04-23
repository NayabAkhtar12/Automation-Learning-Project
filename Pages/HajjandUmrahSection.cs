using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class HajjandUmrahSection : Base
    {
       ReusableMethods R;

        public HajjandUmrahSection(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void HajjSectionTest()
        {
            ReusableMethods.Click(Driver!, hajjUmrahMenu!, "Hajj and Umrah Menu", test);
            ReusableMethods.Click(Driver!, HajjGuideMenu!, "Hajj Guide Menu", test);
            ReusableMethods.Click(Driver!, HajjGuideDay1!, "8th of Dhul Hijjah", test);
            Driver!.Navigate().Back();
            ReusableMethods.Click(Driver!, HajjGuideDay2!, "9th of Dhul Hijjah", test);
            Driver.Navigate().Back();
            ReusableMethods.Click(Driver!, HajjGuideDay3!, "10th of Dhul Hijjah", test);
            Driver.Navigate().Back();
            ReusableMethods.Click(Driver!, HajjGuideDay4!, "11th of Dhul Hijjah", test);
            Driver.Navigate().Back();
            ReusableMethods.Click(Driver!, HajjGuideDay5!, "12th of Dhul Hijjah", test);
            Driver.Navigate().Back();
            Driver.Navigate().Back();
        }

        public void UmrahSectionTest()
        {
            ReusableMethods.Click(Driver!, UmrahGuideMenu!, "Umrah Guide Menu", test);
            ReusableMethods.Click(Driver!, UmrahIhram!, "Umrah - IHRAM", test);
            Driver!.Navigate().Back();
            ReusableMethods.Click(Driver!, UmrahTawaf!, "Umrah - TAWAAF", test);
            Driver.Navigate().Back();
            ReusableMethods.Click(Driver!, UmrahSAEE!, "Umrah - SA'EE", test);
            Driver.Navigate().Back();
            ReusableMethods.Click(Driver!, UmrahShaving!, "Umrah - SHAVING", test);
            Driver.Navigate().Back();
            Driver.Navigate().Back();
        }

        public void FamousPlacesofMakkahTest()
        {
            ReusableMethods.Click(Driver!, FamousPlacesofMakkahMenu!, "Famous Places of Makkah", test);
           // ReusableMethods.Click(Driver!, FamousPlacesofMakkahKaaba!, "Kaaba", test);
          //  Driver!.Navigate().Back();
         //   ReusableMethods.Click(Driver!, FamousPlacesofMakkahMina!, "Mina", test);
         //   Driver.Navigate().Back();
            Driver.Navigate().Back();
        }

        public void FamousPlacesofMedinahTest()
        {
            ReusableMethods.Click(Driver!, FamousPlacesofMedinahMenu!, "Famous Places of Medinah", test);
            //ReusableMethods.Click(Driver!, FamousPlacesofMedinah_AlNabwi!, "Al Masjid an Nabawi", test);
            //Driver!.Navigate().Back();
            //ReusableMethods.Click(Driver!, FamousPlacesofMedinah_UhudMountain!, "Uhud Mountain", test);
            //Driver.Navigate().Back();
            Driver.Navigate().Back();
        }

        public void QiblaDirectionTest()
        {
            ReusableMethods.Click(Driver!, HajhUmrahUQibla!, "Qibla Direction", test);
            Driver!.Navigate().Back();
            Driver.Navigate().Back();
        }
        //Element Locators


        IWebElement? hajjUmrahMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnameshusna");
        IWebElement? HajjGuideMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivhajj");
        IWebElement? HajjGuideDay1 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"8th of Dhul Hijjah\"]");
        IWebElement? HajjGuideDay2 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"9th of Dhul Hijjah\"]");
        IWebElement? HajjGuideDay3 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"10th of Dhul Hijjah\"]");
        IWebElement? HajjGuideDay4 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"11th of Dhul Hijjah\"]");
        IWebElement? HajjGuideDay5 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"12th of Dhul Hijjah\"]");
        IWebElement? HajjGuideDay6 => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"13th of Dhul Hijjah\"]");

        IWebElement? UmrahGuideMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivumrah");
        IWebElement? UmrahIhram => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"IHRAM\"]");
        IWebElement? UmrahTawaf => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"TAWAAF\"]");
        IWebElement? UmrahSAEE => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"SA’EE\"]");
        IWebElement? UmrahShaving => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"SHAVING\"]");

        IWebElement? FamousPlacesofMakkahMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmakkah");
        IWebElement? FamousPlacesofMakkahKaaba => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Kaaba\"]");
        IWebElement? FamousPlacesofMakkahMina => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Mina\"]");

        IWebElement? FamousPlacesofMedinahMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmadina");
        IWebElement? FamousPlacesofMedinah_AlNabwi => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Al Masjid an Nabawi\"]");
        IWebElement? FamousPlacesofMedinah_UhudMountain => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Uhud Mountain\"]");
        IWebElement? HajhUmrahUQibla => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");

    }
}
