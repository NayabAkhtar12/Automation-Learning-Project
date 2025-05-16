using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace NunitAppiumProj.Pages
{
    public class Masjid : Base
    {
        public Masjid(AndroidDriver driver, ExtentTest test)
        {
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void MasjidTest()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver!, MasjidFinderMenu!, "Masjid Finder Menu", test, "Masjid Finder", softAssert);

            Thread.Sleep(5000); 
            ReusableMethods.Navigateback();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By MasjidFinderMenu1 => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid");
        private By MasjidFinderMenu => By.XPath("//android.widget.TextView[@text=\"Masjid Finder\"]");

    }
}
