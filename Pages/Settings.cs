﻿using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using NunitAppiumProj.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace HolyQuran.Pages
{
    public class Settings : Base
    {
        public Settings (AndroidDriver driver, ExtentTest test)
        {
            Base.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
        }

        public void PremiumandMenuMethod()
        {
            SoftAssert softAssert = new SoftAssert();

            ReusableMethods.Click1(driver!, Pro, "Pro Button", test, "", softAssert);
            Thread.Sleep(3000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver!, Menu, "Menu Button", test, "", softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, PrivacyPolicy, "Privacy Policy", test, "Privacy Policy", softAssert);
            Thread.Sleep(7000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver!, Menu, "Menu Button", test, "", softAssert);
            ReusableMethods.Click1(driver!, MoreApps, "More Apps", test, "More Apps", softAssert);
            Thread.Sleep(3000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver!, Menu, "Menu Button", test, "", softAssert);
            ReusableMethods.Click1(driver!, RateUs, "Rate Us", test, "Rate Us!", softAssert);
            Thread.Sleep(3000);
            ReusableMethods.Navigateback();

            ReusableMethods.Click1(driver!, Menu, "Menu Button", test, "", softAssert);
            ReusableMethods.Click1(driver!, ExitApp, "Exit App", test, "Exit", softAssert);
            Thread.Sleep(3000);
            ReusableMethods.Click1(driver!, No, "Do not Exit App", test, "", softAssert);

           // driver!.Navigate().Back();
         
            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By Pro => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPurchaseBtn");
        private By Menu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/menubtn");
        private By PrivacyPolicy => By.XPath("//android.widget.TextView[@text=\"Privacy Policy\"]");
        private By MoreApps => By.XPath("//android.widget.TextView[@text=\"More Apps\"]");
        private By RateUs => By.XPath("//android.widget.TextView[@text=\"Rate Us!\"]");
        private By ExitApp => By.XPath("//android.widget.TextView[@text=\"Exit\"]");
        private By Yes => By.XPath("");
        private By No => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/exit_no");
    }
}
