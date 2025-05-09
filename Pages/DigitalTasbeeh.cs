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
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
            R = new ReusableMethods(driver);
        }

        public void DigitalTasbeehT()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, DigitalTasbeehMenu, "DigitalTasbeehMenu", test, "", softAssert);
            ReusableMethods.Click1(driver, SelectTasbeehbutton, "Select Tasbeeh button", test, "", softAssert);
            ReusableMethods.Click1(driver, SelectTasbeeh, "SelectTasbeeh", test, "", softAssert);
            ReusableMethods.Click1(driver, CountTasbeeh, "CountTasbeeh", test, "", softAssert);
            ReusableMethods.Click1(driver, CountTasbeeh, "CountTasbeeh", test, "", softAssert);
            ReusableMethods.Click1(driver, CountTasbeeh, "CountTasbeeh", test, "", softAssert);

            ReusableMethods.Navigateback();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By DigitalTasbeehMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivtasbeeh");
        private By SelectTasbeehbutton => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        private By SelectTasbeeh => By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvZikar' and @text='الْحَمْدُ لِلَّهِ']");
        private By CountTasbeeh => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtncount");
    }
}
