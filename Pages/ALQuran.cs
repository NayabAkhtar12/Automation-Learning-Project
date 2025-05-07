using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class ALQuran : Base
    {
        ReusableMethods R;

        public ALQuran(AndroidDriver driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Base.test = test ?? throw new ArgumentNullException(nameof(test));
            R = new ReusableMethods(driver);
        }

        public void QuranMajeedModule()
        {
            SoftAssert softAssert = new SoftAssert();

      //    ReusableMethods.Click1(driver, Continuebtn, "Continue from splash Screen", test, softAssert);
            Thread.Sleep(1000);

            ReusableMethods.Click1(driver, ALQuranMenu, "Menu from Home Screen", test, softAssert);
            ReusableMethods.Click1(driver, AlFatiha, "Surah Al-Fatiha", test, softAssert);
            Thread.Sleep(1000);
        //    ReusableMethods.Swipe();
            driver.Navigate().Back();
            Thread.Sleep(1000);

            ReusableMethods.Click1(driver, Surah2, "Surah 2", test, softAssert);
            Thread.Sleep(2000);

            ReusableMethods.Click1(driver!, SelectReciterDropDown, "Clicking RecitersDropdown", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, SelectReciter, "Clicking SelectReciter", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, PlaySurah, "Clicking PlaySurah", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, NextAyah, "Clicking NextAyah", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, PrevAyah, "Clicking PrevAyah", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, BookMarkPage, "Clicking BookMarkPage", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, GotoTranslationsection, "Clicking GotoTranslationsection", test, softAssert);
            Thread.Sleep(3000);

        //    ReusableMethods.Click1(driver!, DownloadedSection, "Clicking DownloadedSection", test, softAssert);
         //   Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, ViewTranslation, "Clicking ViewTranslation", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, TranslationNextPage, "Clicking TranslationNextPage", test, softAssert);
            Thread.Sleep(3000);

            ReusableMethods.Click1(driver!, TranslationPrevPage, "Clicking TranslationPrevPage", test, softAssert);
            Thread.Sleep(3000);

            driver!.Navigate().Back();

            driver.Navigate().Back();
            driver.Navigate().Back();

            softAssert.AllAsserts(test);
        }

        // Element Locators
        private By ALQuranMenu => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        private By AlFatiha => By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName\" and @text=\"Surat Al-Fatiha\"]");
        private By PlaySurah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play");
        private By SelectReciterDropDown => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivrecitersArrow");
        private By RepeatVerse => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/repeat");
        private By ViewList => By.Id(""); // 🔶 This one is empty – you may want to update it
        private By LanguageSave => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btnCacncel");
        private By OnboardSkip => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_skip");
        private By OnboardFinish => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_next_step");
        private By StoragePermissionAllow => By.Id("com.android.permissioncontroller:id/permission_allow_button");
        private By LocationPermissionAllow => By.Id("com.android.permissioncontroller:id/permission_allow_foreground_only_button");
        private By SelectReciter => By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvReciterEng\" and @text=\"Abd Al-Basit Mujawwad\"]");
        private By NextAyah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/forward");
        private By PrevAyah => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/before");
        private By BookMarkPage => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/bookmark");
        private By GotoTranslationsection => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tafser");
        private By AvailableforDownload => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/transtabTv");
        private By DownloadTranslation => By.XPath("(//android.widget.ImageView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivHeaderDownStatus\"])[2]");
        private By DownloadedSection => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tfseerTabTv");
        private By ViewTranslation => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/imageView2");
        private By TranslationPrevPage => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPrevious");
        private By TranslationNextPage => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivNext");
        private By SurahBack => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/back");
        private By Surah2 => By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName\" and @text=\"Surat Al-Baqara\"]");
        private By SurahAnNisa => By.XPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat An-Nisa\"]");
        private By Continuebtn => By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/start_button");


    }
}
