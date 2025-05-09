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
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void QuranFirstSessionFlow()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver, Continue, "Continue", test, "Continue", softAssert);
            Thread.Sleep(3000);
            ReusableMethods.Click1(driver, SelectLanguage, "SelectLanguage", test, "English", softAssert);
            ReusableMethods.Click1(driver, LanguageSave, "", test, "LanguageSave", softAssert);
            ReusableMethods.Click1(driver, StoragePermissionAllow, "StoragePermissionAllow", test," ", softAssert);
            ReusableMethods.Click1(driver, LocationPermissionAllow, "StoragePermissionAllow", test," ", softAssert);
            ReusableMethods.Click1(driver, ALQuranMenu, "AL-Quran", test, "AL-Quran", softAssert);
            ReusableMethods.Click1(driver, Downloadinbackground, "Download in Background", test," ", softAssert);

         //   driver.Navigate().Back();
            softAssert.AllAsserts(test);
        }
     

        // Element Locators
        private By ALQuranMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        private By Continue => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/start_button");
        private By SelectLanguage => By.XPath("//androidx.recyclerview.widget.RecyclerView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/recycler_view\"]/android.view.ViewGroup[1]");
        private By LanguageSave => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btnDone");
        private By Downloadinbackground => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btndownloadinbg");
        private By OnboardFinish => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_next_step");
        private By StoragePermissionAllow => By.Id("com.android.permissioncontroller:id/permission_allow_button");
        private By LocationPermissionAllow => By.Id("com.android.permissioncontroller:id/permission_allow_foreground_only_button");
    }
}
