using System;
using System.Reflection;

/// <summary>
/// AmbiguousMatchException constructor() [v-yaduoj]
/// </summary>
public class AmbiguousMatchExceptionCtor
{
    public static int Main()
    {
        AmbiguousMatchExceptionCtor testObj = new AmbiguousMatchExceptionCtor();

        TestLibrary.TestFramework.BeginTestCase("for AmbiguousMatchException()");
        if (testObj.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;

        return retVal;
    }

    #region Positive tests
    public bool PosTest1()
    {
        bool retVal = true;

        const string c_TEST_ID = "P001";
        string c_TEST_DESC = "PosTest1: initialize an instance of type AmbiguousMatchException via default constructor";
        string errorDesc;

        TestLibrary.TestFramework.BeginScenario(c_TEST_DESC);
        try
        {
            AmbiguousMatchException e = new AmbiguousMatchException();
            if (null == e)
            {
                errorDesc = "Failed to initialize an instance of type AmbiguousMatchException via default constructor.";
                TestLibrary.TestFramework.LogError("001" + " TestId-" + c_TEST_ID, errorDesc);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            errorDesc = "Unexpected exception: " + e;
            TestLibrary.TestFramework.LogError("002" + " TestId-" + c_TEST_ID, errorDesc);
            retVal = false;
        }

        return retVal;
    }

    #endregion
}
