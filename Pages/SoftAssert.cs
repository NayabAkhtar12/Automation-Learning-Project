using AventStack.ExtentReports;

public class SoftAssert
{
    private List<string> _errors = new List<string>();

    public void IsTrue(bool condition, string message)
    {
        if (!condition)
        {
            _errors.Add(message);
        }
    }

    public void AllAsserts(ExtentTest test)
    {
        if (_errors.Any())
        {
            foreach (var error in _errors)
            {
                test.Log(Status.Fail, error);
            }
            Assert.Fail("Soft assertion(s) failed. See above for details.");
        }
    }
}
