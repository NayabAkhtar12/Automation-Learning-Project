using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class Names99 : Base
    {
       ReusableMethods R;

        public Names99(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void NamesSectionTest()
        {
            ReusableMethods.Click(driver!, Namesnine, "Names Section Menu", test);

            // Read Allah Names
            ReusableMethods.Click(driver!, ReadNamesAllah, "Read Names of Allah", test);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Listen Allah Names
            ReusableMethods.Click(driver!, ListenNamesAllah, "Listen Names of Allah", test);
            ReusableMethods.Click(driver!, Nameplay, "Play Button for Allah Names", test);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Read Prophet Names
            ReusableMethods.Click(driver!, ReadNamesHusna, "Read Names of Prophet", test);
            Thread.Sleep(2000);
            driver!.Navigate().Back();

            // Listen Prophet Names
            ReusableMethods.Click(driver!, ListenNamesNabi, "Listen Names of Prophet", test);
            ReusableMethods.Click(driver!, Nameplay, "Play Button for Prophet Names", test);
            Thread.Sleep(2000);
            driver!.Navigate().Back();          
            driver!.Navigate().Back();
        }


        //Element Locators


        IWebElement? Namesnine => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi"));
        IWebElement? ReadNamesHusna => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names"));
        IWebElement? ListenNamesNabi => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names"));
        IWebElement? ReadNamesAllah => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma"));
        IWebElement? ListenNamesAllah => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma"));
        IWebElement? Nameplay => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP"));
        IWebElement? Continue => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton"));
    }
}
