using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace NunitAppiumProj.Pages
{
    public class HajjandUmrahSection : Base
    {
        public HajjandUmrahSection(AndroidDriver driver, ExtentTest test)
        {
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void HajjSectionTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, HajjUmrahMenu, "Hajj and Umrah Menu", test, "", softAssert);
            ReusableMethods.Click1(driver, HajjGuideMenu, "Hajj Guide Menu", test, "", softAssert);

            ReusableMethods.Click1(driver, HajjGuideDay1, "8th of Dhul Hijjah", test, "8th of Dhul Hijjah", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver, HajjGuideDay2, "9th of Dhul Hijjah", test, "9th of Dhul Hijjah", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver, HajjGuideDay3, "10th of Dhul Hijjah", test, "10th of Dhul Hijjah", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver, HajjGuideDay4, "11th of Dhul Hijjah", test, "11th of Dhul Hijjah", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver, HajjGuideDay5, "12th of Dhul Hijjah", test, "12th of Dhul Hijjah", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            ReusableMethods.Navigateback();
            Thread.Sleep(2000);

            softAssert.AllAsserts(test);
        }

        public void UmrahSectionTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, UmrahGuideMenu, "Umrah Guide Menu", test, "", softAssert);

            ReusableMethods.Click1(driver, UmrahIhram, "IHRAM", test, "IHRAM", softAssert);
            Thread.Sleep(2000);
            driver.Navigate().Back();

            ReusableMethods.Click1(driver, UmrahTawaf, "TAWAAF", test, "TAWAAF", softAssert);
            Thread.Sleep(2000);
            driver.Navigate().Back();

            ReusableMethods.Click1(driver, UmrahSAEE, "SA’EE", test, "SA’EE", softAssert);
            Thread.Sleep(2000);
            driver.Navigate().Back();

            ReusableMethods.Click1(driver, UmrahShaving, "SHAVING", test, "SHAVING", softAssert);
            Thread.Sleep(2000);
            driver.Navigate().Back();

            driver.Navigate().Back();
            Thread.Sleep(2000);

            softAssert.AllAsserts(test);
        }

        public void FamousPlacesofMakkahTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, FamousPlacesofMakkahMenu, "Famous Places of Makkah", test, "", softAssert);

            //  ReusableMethods.Click1(driver, FamousPlacesofMakkahKaaba, "Kaaba", test, softAssert);
            // driver.Navigate().Back();

            //   ReusableMethods.Click1(driver, FamousPlacesofMakkahMina, "Mina", test, softAssert);
            Thread.Sleep(1000);

            driver.Navigate().Back();


            softAssert.AllAsserts(test);
        }

        public void FamousPlacesofMedinahTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, FamousPlacesofMedinahMenu, "Famous Places of Medinah", test, "", softAssert);

            // ReusableMethods.Click1(driver, FamousPlacesofMedinah_AlNabwi, "Al Masjid an Nabawi", test, "",softAssert);
            // driver.Navigate().Back();

            //    ReusableMethods.Click1(driver, FamousPlacesofMedinah_UhudMountain, "Uhud Mountain", test,"", softAssert);
            Thread.Sleep(1000);

            driver.Navigate().Back();


            softAssert.AllAsserts(test);
        }

        public void QiblaDirectionTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, HajhUmrahQibla, "Qibla Direction", test, "", softAssert);
            Thread.Sleep(3000);
            driver.Navigate().Back();
            driver.Navigate().Back();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By HajjUmrahMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnameshusna");
        private By HajjGuideMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivhajj");
        private By HajjGuideDay1 => By.XPath("//android.widget.TextView[@text='8th of Dhul Hijjah']");
        private By HajjGuideDay2 => By.XPath("//android.widget.TextView[@text='9th of Dhul Hijjah']");
        private By HajjGuideDay3 => By.XPath("//android.widget.TextView[@text='10th of Dhul Hijjah']");
        private By HajjGuideDay4 => By.XPath("//android.widget.TextView[@text='11th of Dhul Hijjah']");
        private By HajjGuideDay5 => By.XPath("//android.widget.TextView[@text='12th of Dhul Hijjah']");

        private By UmrahGuideMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivumrah");
        private By UmrahIhram => By.XPath("//android.widget.TextView[@text='IHRAM']");
        private By UmrahTawaf => By.XPath("//android.widget.TextView[@text='TAWAAF']");
        private By UmrahSAEE => By.XPath("//android.widget.TextView[@text=\"SA’EE\"]");
        private By UmrahShaving => By.XPath("//android.widget.TextView[@text='SHAVING']");

        private By FamousPlacesofMakkahMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmakkah");
        private By FamousPlacesofMakkahKaaba => By.XPath("//android.widget.TextView[@text='Kaaba']");
        private By FamousPlacesofMakkahMina => By.XPath("//android.widget.TextView[@text='Mina']");

        private By FamousPlacesofMedinahMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmadina");
        private By FamousPlacesofMedinah_AlNabwi => By.XPath("//android.widget.TextView[@text='Al Masjid an Nabawi']");
        private By FamousPlacesofMedinah_UhudMountain => By.XPath("//android.widget.TextView[@text='Uhud Mountain']");

        private By HajhUmrahQibla => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");
    }
}
