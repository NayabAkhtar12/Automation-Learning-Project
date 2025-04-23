using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class DigitalTasbeeh : Base
    {
       ReusableMethods R;

        public DigitalTasbeeh(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void DigitalTasbeehT()
        {
            ReusableMethods.Click(Driver!, DigitalTasbeehMenu!, " DigitalTasbeehMenu", test);
            ReusableMethods.Click(Driver!, SelectTasbeehbutton!, "Select Tasbeeh button", test);
            ReusableMethods.Click(Driver!, SelectTasbeeh!, "SelectTasbeeh", test);
            ReusableMethods.Click(Driver!, CountTasbeeh!, "CountTasbeeh", test);
            ReusableMethods.Click(Driver!, CountTasbeeh!, "CountTasbeeh", test);
            ReusableMethods.Click(Driver!, CountTasbeeh!, "CountTasbeeh", test);
            Driver!.Navigate().Back();
        }

        //Element Locators
          IWebElement? DigitalTasbeehMenu => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivtasbeeh");
        IWebElement? SelectTasbeehbutton=> Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement? SelectTasbeeh => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvZikar\" and @text=\"الْحَمْدُ لِلَّهِ\"]");
        IWebElement? CountTasbeeh => Driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtncount");

    }
}
