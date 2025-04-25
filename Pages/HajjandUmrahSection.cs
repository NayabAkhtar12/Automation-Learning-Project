using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class HajjandUmrahSection : Base
    {
       ReusableMethods R;

        public HajjandUmrahSection(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void HajjSectionTest()
        {
            ReusableMethods.Click(driver!, hajjUmrahMenu!, "Hajj and Umrah Menu", test);
            ReusableMethods.Click(driver!, HajjGuideMenu!, "Hajj Guide Menu", test);
            ReusableMethods.Click(driver!, HajjGuideDay1!, "8th of Dhul Hijjah", test);
            driver!.Navigate().Back();
            ReusableMethods.Click(driver!, HajjGuideDay2!, "9th of Dhul Hijjah", test);
            driver.Navigate().Back();
            ReusableMethods.Click(driver!, HajjGuideDay3!, "10th of Dhul Hijjah", test);
            driver.Navigate().Back();
            ReusableMethods.Click(driver!, HajjGuideDay4!, "11th of Dhul Hijjah", test);
            driver.Navigate().Back();
            ReusableMethods.Click(driver!, HajjGuideDay5!, "12th of Dhul Hijjah", test);
            driver.Navigate().Back();
            driver.Navigate().Back();
        }

        public void UmrahSectionTest()
        {
            ReusableMethods.Click(driver!, UmrahGuideMenu!, "Umrah Guide Menu", test);
            ReusableMethods.Click(driver!, UmrahIhram!, "Umrah - IHRAM", test);
            driver!.Navigate().Back();
            ReusableMethods.Click(driver!, UmrahTawaf!, "Umrah - TAWAAF", test);
            driver.Navigate().Back();
            ReusableMethods.Click(driver!, UmrahSAEE!, "Umrah - SA'EE", test);
            driver.Navigate().Back();
            ReusableMethods.Click(driver!, UmrahShaving!, "Umrah - SHAVING", test);
            driver.Navigate().Back();
            driver.Navigate().Back();
        }

        public void FamousPlacesofMakkahTest()
        {
            ReusableMethods.Click(driver!, FamousPlacesofMakkahMenu!, "Famous Places of Makkah", test);
           // ReusableMethods.Click(Driver!, FamousPlacesofMakkahKaaba!, "Kaaba", test);
          //  Driver!.Navigate().Back();
         //   ReusableMethods.Click(Driver!, FamousPlacesofMakkahMina!, "Mina", test);
         //   Driver.Navigate().Back();
            driver.Navigate().Back();
        }

        public void FamousPlacesofMedinahTest()
        {
            ReusableMethods.Click(driver!, FamousPlacesofMedinahMenu!, "Famous Places of Medinah", test);
            //ReusableMethods.Click(Driver!, FamousPlacesofMedinah_AlNabwi!, "Al Masjid an Nabawi", test);
            //Driver!.Navigate().Back();
            //ReusableMethods.Click(Driver!, FamousPlacesofMedinah_UhudMountain!, "Uhud Mountain", test);
            //Driver.Navigate().Back();
            driver.Navigate().Back();
        }

        public void QiblaDirectionTest()
        {
            ReusableMethods.Click(driver!, HajhUmrahUQibla!, "Qibla Direction", test);
            driver!.Navigate().Back();
            driver.Navigate().Back();
        }
        //Element Locators


        IWebElement? hajjUmrahMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnameshusna"));
        IWebElement? HajjGuideMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivhajj"));
        IWebElement? HajjGuideDay1 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"8th of Dhul Hijjah\"]"));
        IWebElement? HajjGuideDay2 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"9th of Dhul Hijjah\"]"));
        IWebElement? HajjGuideDay3 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"10th of Dhul Hijjah\"]"));
        IWebElement? HajjGuideDay4 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"11th of Dhul Hijjah\"]"));
        IWebElement? HajjGuideDay5 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"12th of Dhul Hijjah\"]"));
        IWebElement? HajjGuideDay6 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"13th of Dhul Hijjah\"]"));

        IWebElement? UmrahGuideMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivumrah"));
        IWebElement? UmrahIhram => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"IHRAM\"]"));
        IWebElement? UmrahTawaf => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"TAWAAF\"]"));
        IWebElement? UmrahSAEE => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"SA’EE\"]"));
        IWebElement? UmrahShaving => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"SHAVING\"]"));

        IWebElement? FamousPlacesofMakkahMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmakkah"));
        IWebElement? FamousPlacesofMakkahKaaba => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Kaaba\"]"));
        IWebElement? FamousPlacesofMakkahMina => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Mina\"]"));

        IWebElement? FamousPlacesofMedinahMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmadina"));
        IWebElement? FamousPlacesofMedinah_AlNabwi => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Al Masjid an Nabawi\"]"));
        IWebElement? FamousPlacesofMedinah_UhudMountain => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Uhud Mountain\"]"));
        IWebElement? HajhUmrahUQibla => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla"));

    }
}
