using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class DigitalTasbeeh : Base
    {
       ReusableMethods R;

        public DigitalTasbeeh(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void DigitalTasbeehT()
        {
            ReusableMethods.Click(driver!, DigitalTasbeehMenu!, " DigitalTasbeehMenu", test);
            ReusableMethods.Click(driver!, SelectTasbeehbutton!, "Select Tasbeeh button", test);
            ReusableMethods.Click(driver!, SelectTasbeeh!, "SelectTasbeeh", test);
            ReusableMethods.Click(driver!, CountTasbeeh!, "CountTasbeeh", test);
            ReusableMethods.Click(driver!, CountTasbeeh!, "CountTasbeeh", test);
            ReusableMethods.Click(driver!, CountTasbeeh!, "CountTasbeeh", test);
            driver!.Navigate().Back();
        }

        //Element Locators
        IWebElement? DigitalTasbeehMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivtasbeeh"));
        IWebElement? SelectTasbeehbutton => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh"));
        IWebElement? SelectTasbeeh => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvZikar\" and @text=\"الْحَمْدُ لِلَّهِ\"]"));
        IWebElement? CountTasbeeh => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtncount"));
    }
}
