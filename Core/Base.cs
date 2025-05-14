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
        protected static AndroidDriver? driver;
        protected ExtentReports Extent = new ExtentReports();
        protected static ExtentTest? test;

        private ExtentSparkReporter? _reporter;

        //protected AndroidDriver? Driver
        //{
        //    get => driver;
        //    set => driver = value;
        //}
       // protected AppiumDriver<AndroidElement> Driver => driver ?? throw new NullReferenceException("Driver not initialized.");

        [OneTimeSetUp]
        protected void OneTimeSetup()
        {
            string reportPath = @"D:\Reports\report.html";  
            _reporter = new ExtentSparkReporter(reportPath);
            Extent.AttachReporter(_reporter);
        }

        [SetUp]
       

        protected void Setup()
        {
            try
            {
                AppiumOptions capabilities = new AppiumOptions();

                capabilities.PlatformName = "Android"; 
                capabilities.PlatformVersion = "11";   
                capabilities.DeviceName = "Tecno Spark 7";  
                capabilities.AutomationName = AutomationName.AndroidUIAutomator2; 

                capabilities.AddAdditionalAppiumOption("udid", "069793717K109606");  //ONOZSG4H8HSGW8HY
                capabilities.AddAdditionalAppiumOption("newCommandTimeout", 300);
                capabilities.AddAdditionalAppiumOption("ignoreHiddenApiPolicyError", true);
                capabilities.AddAdditionalAppiumOption("disableWindowAnimation", true);
                capabilities.AddAdditionalAppiumOption("autoGrantPermissions", true);


                string appiumUri = "http://192.168.100.42:4723/";
                driver = new AndroidDriver(new Uri(appiumUri), capabilities, TimeSpan.FromSeconds(180));
                if (driver == null)
                {
                    throw new InvalidOperationException("Appium driver is null. Initialization failed.");
                }
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

        public void RunTest(string testName, Action testSteps)
        {
            test = Extent.CreateTest(testName);
            try
            {
                test.Log(Status.Info, $"Starting {testName}");
                testSteps();
                test.Log(Status.Pass, $"{testName} completed successfully.");
            }
            catch (AssertionException ex)
            {
                test.Fail("Assertion failed: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                test.Fail("Unexpected error: " + ex.Message);
                throw;
            }
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
                        ReusableMethods.AttachScreenshot(driver, test);
                    }

              
                    driver.Quit();
                    driver.Dispose();
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
