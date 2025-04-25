using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class HijriCalender : Base
    {
       ReusableMethods R;

        public HijriCalender(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void CalenderTest()
        {
            ReusableMethods.Click(driver!, hijriCalendarMenu!, " hijriCalendarMenu", test);
            Thread.Sleep(2000);
            ReusableMethods.Click(driver!, PrevMonth!, " PrevMonth", test);
            ReusableMethods.Click(driver!, NextMonth!, " NextMonth", test);
            ReusableMethods.Click(driver!, Date!, " Date", test);
            Thread.Sleep(2000);
            ReusableMethods.Click(driver!, RamadanCalenderelement!, " RamadanCalender", test);
            Thread.Sleep(2000);
            driver!.Navigate().Back();
            driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement hijriCalendarMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivcalendar"));
        IWebElement PrevMonth => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/prev_month"));
        IWebElement NextMonth => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month"));
        IWebElement Date => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/gregorian_calendar_day\" and @text=\"14\"]"));
        IWebElement RamadanCalenderelement => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivArrowRamzan"));
    }
}
