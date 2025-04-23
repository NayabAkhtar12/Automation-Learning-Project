using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class Names99 : Base
    {
       ReusableMethods R;

        public Names99(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void NamesSectionTest()
        {
            ReusableMethods.Click(Driver!, Namesnine, "Names Section Menu", test);

            // Read Allah Names
            ReusableMethods.Click(Driver!, ReadNamesAllah, "Read Names of Allah", test);
            Thread.Sleep(2000);
            Driver!.Navigate().Back();

            // Listen Allah Names
            ReusableMethods.Click(Driver!, ListenNamesAllah, "Listen Names of Allah", test);
            ReusableMethods.Click(Driver!, Nameplay, "Play Button for Allah Names", test);
            Thread.Sleep(2000);
            Driver!.Navigate().Back();

            // Read Prophet Names
            ReusableMethods.Click(Driver!, ReadNamesHusna, "Read Names of Prophet", test);
            Thread.Sleep(2000);
            Driver!.Navigate().Back();

            // Listen Prophet Names
            ReusableMethods.Click(Driver!, ListenNamesNabi, "Listen Names of Prophet", test);
            ReusableMethods.Click(Driver!, Nameplay, "Play Button for Prophet Names", test);
            Thread.Sleep(2000);
            Driver!.Navigate().Back();          
            Driver!.Navigate().Back();
        }


        //Element Locators


        IWebElement? Namesnine => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        IWebElement? ReadNamesHusna => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names");
        IWebElement? ListenNamesNabi => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names");
        IWebElement? ReadNamesAllah => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma");
        IWebElement? ListenNamesAllah => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma");
        IWebElement? Nameplay => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP");
        IWebElement? Continue => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");

    }
}
