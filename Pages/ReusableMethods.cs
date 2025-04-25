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
            this.driver = driver;
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        //public static void HandleException(Exception ex, string context)
        //{
        //    // Log the exception message and stack trace
        //    Console.WriteLine($"Exception occurred: {context}");
        //    Console.WriteLine($"Message: {ex.Message}");
        //    Console.WriteLine($"StackTrace: {ex.StackTrace}");

        //    // Optionally, you can fail the test if this is called from a test method
        //    Assert.Fail($"Test failed due to exception: {ex.Message}");
        //}
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

}
}
