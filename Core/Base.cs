using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NunitAppiumProj.Pages;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace NunitAppiumProj.Core
{
    [TestFixture]
    public class Base
    {
        private AppiumDriver<AndroidElement>? driver;
        protected ExtentReports Extent = new ExtentReports();
        protected ExtentTest? test;

        private ExtentSparkReporter? _reporter;

        protected AppiumDriver<AndroidElement>? Driver
        {
            get => driver;
            set => driver = value;
        }
       // protected AppiumDriver<AndroidElement> Driver => driver ?? throw new NullReferenceException("Driver not initialized.");

        [OneTimeSetUp]
        protected void OneTimeSetup()
        {
            string reportPath = @"D:\Reports\report.html";  
            _reporter = new ExtentSparkReporter(reportPath);
            Extent.AttachReporter(_reporter);
        }

        [SetUp]
        //OPPO A16    ONOZSG4H8HSGW8HY
        //TECNO SPARK 7   069793717K109606
        //adb shell pm list packages | findstr holyquran
        //adb shell cmd package resolve-activity --brief<package_name>

        protected void Setup()
        {
            try
            {
                // Initialize Appium Options
                AppiumOptions capabilities = new AppiumOptions();

                //required capabilities
                capabilities.AddAdditionalCapability("platformName", "Android");
                capabilities.AddAdditionalCapability("platformVersion", "11"); // Match your actual Android version
                capabilities.AddAdditionalCapability("deviceName", "OPPO A16"); // Match your device name
                capabilities.AddAdditionalCapability("udid", "ONOZSG4H8HSGW8HY"); // Match your device UDID
                capabilities.AddAdditionalCapability("appPackage", "com.seaofgames.aichat.aiapps"); // Match your app's package
                capabilities.AddAdditionalCapability("appActivity", ".ui.activities.SplashActivity"); // Match your app's activity
                capabilities.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
               // capabilities.AddAdditionalCapability("noReset", true);
                capabilities.AddAdditionalCapability("newCommandTimeout", 300);
                capabilities.AddAdditionalCapability("ignoreHiddenApiPolicyError", true); 
                capabilities.AddAdditionalCapability("disableWindowAnimation", true); 
                capabilities.AddAdditionalCapability("autoGrantPermissions", true);
                string appiumUri = "http://192.168.100.42:4723/"; 
                driver = new AndroidDriver<AndroidElement>(new Uri(appiumUri), capabilities, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Console.WriteLine("Driver initialized successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error during driver initialization: {e.Message}");
            }
        }


        protected void HandleException1(Exception ex, string context)
        {
            test?.Fail($"Exception in {context}: {ex.Message}");
            test?.Fail(ex.StackTrace);
            Console.WriteLine($"Exception occurred: {context}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            Assert.Fail($"Test failed due to exception: {ex.Message}");
        }

        [TearDown]
        protected void TearDown()
        {
            try
            {
                if (driver != null)
                {
                    if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
                    {
                        ReusableMethods.AttachScreenshot(Driver, test);
                    }

                    driver.Quit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [OneTimeTearDown]
        protected void OneTimeTearDown()
        {
            Extent.Flush();
        }
    }

}
