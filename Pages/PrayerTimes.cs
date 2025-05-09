using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace NunitAppiumProj.Pages
{
    public class PrayerTimes : Base
    {

        public PrayerTimes(AndroidDriver driver, ExtentTest test)
        {
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void PrayerTimesTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, prayerTimesMenu, "Prayer Times Menu", test, "", softAssert);
            ReusableMethods.Click1(driver, PrayerTimeNotification, "Prayer Time Notification", test, "", softAssert);

            Thread.Sleep(3000);
            ReusableMethods.Navigateback();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By prayerTimesMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivprayers");
        private By PrayerTimeNotification => By.XPath("(//android.widget.ImageView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ib_notification'])[3]");
    }
}
