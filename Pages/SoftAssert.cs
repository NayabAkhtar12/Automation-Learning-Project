using AventStack.ExtentReports;

public class SoftAssert
{
    private List<string> _errors = new List<string>();

    public void Contains(string expectedSubstring, string actual, string message)
    {
        if (!actual.Contains(expectedSubstring))
        {
            _errors.Add($"{message} | Expected to contain: '{expectedSubstring}', but got: '{actual}'");
        }
    }
    public void AreEqual(string expected, string actual, string message)
    {
        if (!string.Equals(expected, actual))
        {
            _errors.Add($"{message} | Expected: '{expected}' but got: '{actual}'");
        }
    }

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
            string failureMessage = "Soft assertion(s) failed:\n" + string.Join("\n", _errors,"\n");
            test?.Log(Status.Fail, failureMessage);
            Assert.Fail(failureMessage);
        }
        else
        {
            test?.Log(Status.Pass, "All soft assertions passed.");
        }
    }
}
