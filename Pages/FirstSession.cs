using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Threading;

namespace NunitAppiumProj.Pages
{
    public class FirstSession : Base
    {
        public FirstSession(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void QuranFirstSessionFlow()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, Continue, "Clicking Continue", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver, LanguageSave, "Clicking Language Save", test, softAssert);
            ReusableMethods.Click1(driver, OnboardSkip, "Clicking Onboard Skip", test, softAssert);
            ReusableMethods.Click1(driver, OnboardFinish, "Clicking Onboard Finish", test, softAssert);
            ReusableMethods.Click1(driver, StoragePermissionAllow, "Allowing Storage Permission", test, softAssert);
            ReusableMethods.Click1(driver, LocationPermissionAllow, "Allowing Location Permission", test, softAssert);

            softAssert.AllAsserts(test);
        }
        public void AlQuranDownload()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, ALQuranMenu, "Clicking Quran Menu", test, softAssert);
            Thread.Sleep(60000);

            driver.Navigate().Back();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By ALQuranMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        private By Continue => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
        private By LanguageSave => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btnCacncel");
        private By OnboardSkip => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_skip");
        private By OnboardFinish => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_next_step");
        private By StoragePermissionAllow => By.Id("com.android.permissioncontroller:id/permission_allow_button");
        private By LocationPermissionAllow => By.Id("com.android.permissioncontroller:id/permission_allow_foreground_only_button");
    }
}
