using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class HijriCalender : Base
    {
       ReusableMethods R;

        public HijriCalender(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void CalenderTest()
        {
            ReusableMethods.Click(Driver!, hijriCalendarMenu!, " hijriCalendarMenu", test);
            Thread.Sleep(2000);
            ReusableMethods.Click(Driver!, PrevMonth!, " PrevMonth", test);
            ReusableMethods.Click(Driver!, NextMonth!, " NextMonth", test);
            ReusableMethods.Click(Driver!, Date!, " Date", test);
            Thread.Sleep(2000);
            ReusableMethods.Click(Driver!, RamadanCalenderelement!, " RamadanCalender", test);
            Thread.Sleep(2000);
            Driver!.Navigate().Back();
            Driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement hijriCalendarMenu => Driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivcalendar");
        IWebElement PrevMonth => Driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/prev_month");
        IWebElement NextMonth => Driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month");
        IWebElement Date => Driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/gregorian_calendar_day\" and @text=\"14\"]");
        IWebElement RamadanCalenderelement => Driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivArrowRamzan");

    }
}
