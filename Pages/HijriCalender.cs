using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace NunitAppiumProj.Pages
{
    public class HijriCalender : Base
    {
        ReusableMethods R;

        public HijriCalender(AndroidDriver driver, ExtentTest test)
        {
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
            R = new ReusableMethods(driver);
        }

        public void CalenderTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, hijriCalendarMenu, "Hijri Calendar Menu", test, "", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Click1(driver, PrevMonth, "Previous Month", test, "", softAssert);
            ReusableMethods.Click1(driver, NextMonth, "Next Month", test, "", softAssert);
            ReusableMethods.Click1(driver, Date, "Date 14", test, "", softAssert);
            Thread.Sleep(2000);
            ReusableMethods.Click1(driver, RamadanCalendarElement, "Ramadan Calendar Element", test, "", softAssert);
            Thread.Sleep(2000);

            ReusableMethods.Navigateback();
            ReusableMethods.Navigateback();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By hijriCalendarMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivcalendar");
        private By PrevMonth => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/prev_month");
        private By NextMonth => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month");
        private By Date => By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/gregorian_calendar_day' and @text='14']");
        private By RamadanCalendarElement => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivArrowRamzan");
    }
}
