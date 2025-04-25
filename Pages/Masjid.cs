using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class Masjid : Base
    {
       ReusableMethods R;

        public Masjid(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }

        public void MasjidTest()
        {
            ReusableMethods.Click(driver!, masjidFinderMenu!, " masjidFinderMenu", test);
            Thread.Sleep(5000);
            driver!.Navigate().Back();
        }

        //Element Locators


        IWebElement masjidFinderMenu => driver.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid"));

    }
}
