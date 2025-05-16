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
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void QiblaFinderT()
        {
               SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, QiblaFindermenu, "Menu from Home Screen", test, "Qibla Finder", softAssert);
                ReusableMethods.Click1(driver, SelectCompassMenu, "Select Compass Menu", test, "", softAssert);
                ReusableMethods.Click1(driver, Theme, "Theme", test, "", softAssert);
                Thread.Sleep(2000);
            ReusableMethods.Navigateback();
            softAssert.AllAsserts(test); 
        }




        //Element Locator for Surah Location
        private By QiblaFindermenu1 = By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");
        private By QiblaFindermenu = By.XPath("//android.widget.TextView[@text=\"Qibla Finder\"]");
        public By SelectCompassMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        public By Theme => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla3");
    }
}
