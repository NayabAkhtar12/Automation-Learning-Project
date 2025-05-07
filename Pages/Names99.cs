using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace NunitAppiumProj.Pages
{
    public class Names99 : Base
    {
        public Names99(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void NamesSectionTest()
        {
            SoftAssert softAssert = new SoftAssert();

            // Test flow using reusable methods
            ReusableMethods.Click1(driver!, Namesnine!, "Names Section Menu", test, softAssert);

            // Read Allah Names
            ReusableMethods.Click1(driver!, ReadNamesAllah!, "Read Names of Allah", test, softAssert);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Listen Allah Names
            ReusableMethods.Click1(driver!, ListenNamesAllah!, "Listen Names of Allah", test, softAssert);
            ReusableMethods.Click1(driver!, Nameplay!, "Play Button for Allah Names", test, softAssert);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Read Prophet Names
            ReusableMethods.Click1(driver!, ReadNamesHusna!, "Read Names of Prophet", test, softAssert);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Listen Prophet Names
            ReusableMethods.Click1(driver!, ListenNamesNabi!, "Listen Names of Prophet", test, softAssert);
            ReusableMethods.Click1(driver!, Nameplay!, "Play Button for Prophet Names", test, softAssert);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Final back navigation to go to the main screen
            driver!.Navigate().Back();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By Namesnine => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        private By ReadNamesHusna => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names");
        private By ListenNamesNabi => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names");
        private By ReadNamesAllah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma");
        private By ListenNamesAllah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma");
        private By Nameplay => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP");
        private By Continue => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
    }
}
