using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace NunitAppiumProj.Core
{
    [TestFixture]
    public class Base
    {
        protected AppiumDriver<AndroidElement>? driver;
        public static ExtentReports Extent;
        protected ExtentTest? test;

        private static ExtentSparkReporter? _reporter;

        //public AppiumDriver<AndroidElement>? Driver
        //{
        //    get
        //    {
        //        return driver;
        //    }
        //}
        public AppiumDriver<AndroidElement> Driver => driver ?? throw new NullReferenceException("Driver not initialized.");

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            string reportPath = @"D:\Reports\report.html";  // Ensure you are using the correct folder path
            _reporter = new ExtentSparkReporter(reportPath);
            Extent = new ExtentReports();
            Extent.AttachReporter(_reporter);
        }

        [SetUp]
        //OPPO A16    ONOZSG4H8HSGW8HY
        //TECNO SPARK 7   069793717K109606
        //adb shell pm list packages | findstr holyquran
        //adb shell cmd package resolve-activity --brief<package_name>

        public void Setup()
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

                // Ensure that the automationName is properly set
                capabilities.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);

                // Additional capabilities for stability and testing
               // capabilities.AddAdditionalCapability("noReset", true);
                capabilities.AddAdditionalCapability("newCommandTimeout", 300);
                capabilities.AddAdditionalCapability("ignoreHiddenApiPolicyError", true); // Must-have for API errors
                capabilities.AddAdditionalCapability("disableWindowAnimation", true); // Prevent UI flakiness
                capabilities.AddAdditionalCapability("autoGrantPermissions", true);

                // Define Appium server URI
                string appiumUri = "http://192.168.100.42:4723/"; // Default local Appium server
             //   Uri serverUri = new Uri(appiumUri);

                // Initialize driver
                driver = new AndroidDriver<AndroidElement>(new Uri(appiumUri), capabilities, TimeSpan.FromSeconds(180));

                // Set implicit wait time
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

              //  driver?.LaunchApp();

                Console.WriteLine("Driver initialized successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error during driver initialization: {e.Message}");
                HandleException1(e, "Failed to initialize driver in Setup");
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
        public void TearDown()
        {
            try
            {
                if (driver != null)
                {
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
        public void OneTimeTearDown()
        {
            Extent.Flush();
        }
    }

}
