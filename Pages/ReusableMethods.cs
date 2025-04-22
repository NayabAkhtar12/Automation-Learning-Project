using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class ReusableMethods : Base
    {

        public ReusableMethods(AppiumDriver<AndroidElement>? driver)
        {
            this.driver = driver;
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }


        public static void HandleException(Exception ex, string context)
        {
            // Log the exception message and stack trace
            Console.WriteLine($"Exception occurred: {context}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");

            // Optionally, you can fail the test if this is called from a test method
            Assert.Fail($"Test failed due to exception: {ex.Message}");
        }
        public static void Click(IWebDriver driver, IWebElement element, string elementname, ExtentTest? Test)
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(driver =>
                {
                    try
                    {
                        return element.Displayed && element.Enabled;
                    }
                    catch
                    {
                        return false;
                    }
                });

                element?.Click();
                Test?.Info($"Clicked {elementname}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error clicking {elementname}: {e.Message}");
                Assert.Fail($"Failed to click {elementname}: {e.Message}");
            }
        }
        public static void Swipe(AppiumDriver<AndroidElement> driver, int startX, int startY, int endX, int endY)
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
