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
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void NamesSectionTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver!, Namesnine!, "Names Section Menu", test, "99 Names", softAssert);

            // Read Allah Names
            ReusableMethods.Click1(driver!, ReadNamesAllah!, "Read Names of Allah", test, "", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            // Listen Allah Names
            ReusableMethods.Click1(driver!, ListenNamesAllah!, "Listen Names of Allah", test, "", softAssert);
            ReusableMethods.Click1(driver!, Nameplay!, "Play Button for Allah Names", test, "", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            // Read Prophet Names
            ReusableMethods.Click1(driver!, ReadNamesHusna!, "Read Names of Prophet", test, "", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            // Listen Prophet Names
            ReusableMethods.Click1(driver!, ListenNamesNabi!, "Listen Names of Prophet", test, "", softAssert);
            ReusableMethods.Click1(driver!, Nameplay!, "Play Button for Prophet Names", test, "", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Navigateback();

            // Final back navigation to go to the main screen
            ReusableMethods.Navigateback();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By Namesnine1 => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        private By Namesnine => By.XPath("//android.widget.TextView[@text=\"99 Names\"]");

        private By ReadNamesHusna => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names");
        private By ListenNamesNabi => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names");
        private By ReadNamesAllah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma");
        private By ListenNamesAllah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma");
        private By Nameplay => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP");
        private By Continue => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
    }
}
