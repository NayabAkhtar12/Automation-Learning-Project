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
            this.test = test ?? throw new ArgumentNullException(nameof(test));
            R=new ReusableMethods(driver);
        }


        public void QuranMajeedModule()
        {
            SoftAssert softAssert = new SoftAssert();

            try
            {
                ReusableMethods.Click1(driver!, Continue!, "Continue from splash Screen", test, softAssert);
                Thread.Sleep(1000);

                ReusableMethods.Click1(driver!, ALQuranMenu!, "Menu from Home Screen", test, softAssert);
                ReusableMethods.Click1(driver!, AlFatiha!, "Surah Al-Fatiha", test, softAssert);
                Thread.Sleep(1000);
                driver!.Navigate().Back();
                Thread.Sleep(1000);
                ReusableMethods.Click1(driver, Surah2!, "Surah 2", test, softAssert);
                Thread.Sleep(2000);
                driver.Navigate().Back();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException(driver, test, "Al Quran", ex);
                throw;
            }
            finally
            {
                softAssert.AllAsserts(test); 
            }
        }

        public void QuranMajeedModule1()
        {
            //  ReusableMethods.SplashHandling2ndsessiont();

            try
            {
                ReusableMethods.Click(driver!, Continue!, "Continue from splash Screen", test);
                Thread.Sleep(1000);

                ReusableMethods.Click(driver!, ALQuranMenu!, "Menu from Home Screen", test);
                ReusableMethods.Click(driver!, AlFatiha!, "Surah Al-Fatiha", test);
                Thread.Sleep(1000);
                driver!.Navigate().Back();
                Thread.Sleep(1000);
                ReusableMethods.Click(driver, Surah2!, "Surah 2", test);
                Thread.Sleep(2000);
                driver.Navigate().Back();
                driver.Navigate().Back();

              
            }
            catch (Exception ex)
            {
                //test.Log(Status.Fail, $"Test failed in QuranMajeedModule: {ex.Message}");
                ReusableMethods.HandleException(driver,test,"Al Quran",ex);
                    throw;
            }

        }




        //Element Locator for Surah Location
        IWebElement? ALQuranMenu => driver.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran"));

        //Web Elements
        IWebElement? AlFatiha => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName' and @text='Surat Al-Fatiha']"));
        IWebElement? PlaySurah => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play"));
        IWebElement? Surah2 => driver?.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/soraName' and @text='Surat Al-Baqara']"));
        IWebElement? Continue => driver?.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/start_button"));


    }
}
