using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class QiblaFinder : Base
    {
       ReusableMethods R;

        public QiblaFinder(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }


        public void QiblaFinderT()
        {
            ReusableMethods.Click(driver!, QiblaFindermenu!, "Menu from Home Screen", test);
            ReusableMethods.Click(driver!, SelectCompassMenu!, "SelectCompassMenu", test);
            ReusableMethods.Click(driver!, Theme!, "Theme", test);
            Thread.Sleep(2000);
            driver!.Navigate().Back();
            //Driver!.Navigate().Back();

        }

        //Element Locator for Surah Location

        IWebElement? QiblaFindermenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla"));

        IWebElement? SelectCompassMenu => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh"));

        IWebElement? Theme => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla3"));
    }
}
