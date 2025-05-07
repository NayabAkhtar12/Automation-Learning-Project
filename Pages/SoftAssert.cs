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

    public void AllAsserts(ExtentTest? test = null)
    {
        if (_errors.Count > 0)
        {
            Assert.Fail("Soft assertion(s) failed:\n" + string.Join("\n", _errors));
        }
        else
        {
            test?.Log(Status.Pass, "All soft assertions passed.");
        }
    }
}
