using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class ReusableMethods : Base
    {

        public ReusableMethods(AndroidDriver? driver)
        {
            Base.driver = driver;
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        public static void Click(AndroidDriver driver, By locator, string ElementName, ExtentTest? test, string expectedText, SoftAssert softAssert)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                IWebElement element = wait.Until(drv => drv.FindElement(locator));
                wait.Until(drv => element.Displayed && element.Enabled);
                 string actualText = element.Text;
                //  IWebElement expectedElement = driver.FindElement(locator);
                // string actualText = element.GetAttribute("text");

              //  test?.Log(Status.Info, $"Actual text of {ElementName}: '{actualText}'");


                if (!string.IsNullOrWhiteSpace(expectedText))
                {
                    softAssert.Contains(expectedText, actualText, $"Text mismatch before clicking {ElementName}");
                }
                softAssert.IsTrue(element.Displayed && element.Enabled, $"Element '{locator}' should be visible and enabled.");
                test?.Log(Status.Info, $"Element located: {ElementName}");
                element.Click();
                test?.Log(Status.Pass, $"Clicked: {ElementName}");
            }
            catch (Exception ex)
            {
                string message = $"Error clicking on {expectedText}: {ex.Message}";
                test?.Log(Status.Fail, message);
                softAssert.IsTrue(false, message);
                AttachScreenshot(driver, test);
            }
        }

        public static void Click1(AndroidDriver driver, By locator, string ElementName, ExtentTest? test, string expectedText, SoftAssert softAssert)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element;

            try
            {
                try
                {
                    element = wait.Until(drv =>
                    {
                        var el = drv.FindElement(locator);
                        return (el.Displayed && el.Enabled) ? el : null;
                    });

                    softAssert.IsTrue(true, $"Element '{ElementName}' is visible and enabled.");
                }
                catch (Exception innerEx)
                {
                    string msg = $"Element '{ElementName}' not found or not visible/enabled. Exception: {innerEx.Message}";
                    test?.Log(Status.Fail, msg);
                    softAssert.IsTrue(false, msg);
                    AttachScreenshot(driver, test);
                    return;
                }

                string actualText = element.Text;
              test?.Log(Status.Info, $"Actual text of {ElementName}: '{actualText}'");
                if (!string.IsNullOrWhiteSpace(expectedText))
                {
                    softAssert.Contains(expectedText, actualText, $"Text mismatch before clicking {ElementName}");
                }

            //    test?.Log(Status.Info, $"Element located and verified: {ElementName}");
                element.Click();
                test?.Log(Status.Pass, $"Clicked: {ElementName}");
            }
            catch (Exception ex)
            {
                string message = $"Unexpected error while clicking '{ElementName}': {ex.Message}";
                test?.Log(Status.Fail, message);
                softAssert.IsTrue(false, message);
                AttachScreenshot(driver, test);
            }
        }




        public static void Click(AndroidDriver driver, IWebElement element, string elementname, ExtentTest? test)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(drv => element.Displayed && element.Enabled);


                element.Click();
                test.Log(Status.Pass, $"Clicked: {elementname}");
            }
      
            catch (Exception ex)
            {
                string message = $"Error clicking on {elementname}: {ex.Message}";
                test.Log(Status.Fail, message);
                Assert.That(element.Displayed, "Not displayed");
                Assert.That(false, "Click failed due to missing element.");
                AttachScreenshot(driver, test);
                throw;
            }
            

        }

        public static void HandleException(AndroidDriver driver, ExtentTest? test, string actionName, Exception ex)
        {
            test?.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");
            Assert.That(false, "Click failed due to missing element.");
            try
            {
                Screenshot screenshot = driver.GetScreenshot();
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = @$"D:\Reports\screenshot_{timestamp}.png";

                screenshot.SaveAsFile(filePath);
                Console.WriteLine($"Screenshot saved to: {filePath}");

                test?.AddScreenCaptureFromPath(filePath);
            }
            catch (Exception screenshotException)
            {
                test?.Log(Status.Warning, $"Failed to capture screenshot: {screenshotException.Message}");
            }
        }

        public static void AttachScreenshot(AndroidDriver driver, ExtentTest test)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string screenshotPath = Path.Combine(Directory.GetCurrentDirectory(), $"Screenshot_{timestamp}.png");
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotPath);
                test.AddScreenCaptureFromPath(screenshotPath);
            }
            catch (Exception ex)
            {
                test.Log(Status.Warning, $"Failed to capture screenshot: {ex.Message}");
            }
        }

        public static void Swipe(AndroidDriver driver, int startX, int startY, int endX, int endY)
        {
            try
            {
                var actions = new OpenQA.Selenium.Interactions.Actions(driver);

                // First move to an absolute position (startX, startY)
                actions.MoveByOffset(0, 0)  // Ensure the starting point uses absolute position
                    .MoveToElement(driver.FindElement(By.XPath("//android.widget.TextView[@resource-id='yourElement']")))  // Or use an element for reference
                    .ClickAndHold()  // Press and hold the element
                    .MoveByOffset(endX - startX, endY - startY)  // Swipe movement in absolute screen coordinates
                    .Release()  // Release after swipe
                    .Perform();

                Thread.Sleep(1000);  // Optional: adjust based on your needs
            }
            catch (Exception ex)
            {
                Console.WriteLine("Swipe failed: " + ex.Message);
                Assert.Fail("Swipe failed: " + ex.Message);
            }
        }

        public static void Navigateback()
        {
            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
}
}
