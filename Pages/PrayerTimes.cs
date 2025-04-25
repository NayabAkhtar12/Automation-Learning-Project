using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class PrayerTimes : Base
    {
       ReusableMethods R;

        public PrayerTimes(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void PrayerTimesTest()
        {
            ReusableMethods.Click(driver!, prayerTimesMenu!, " prayerTimesMenu", test);
            ReusableMethods.Click(driver!, PrayerTimeNotification!, " prayerTimesMenu", test);
            Thread.Sleep(3000);
            driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement? PrayerTimeNotification => driver?.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ib_notification\"])[3]"));
        IWebElement? prayerTimesMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivprayers"));
    }
}
