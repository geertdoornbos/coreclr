using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// UInt32.System.IConvertible.ToBoolean
/// </summary>
public class UInt32IConvertibleToBoolean
{
    public static int Main()
    {
        UInt32IConvertibleToBoolean ui32ictbool = new UInt32IConvertibleToBoolean();
        TestLibrary.TestFramework.BeginTestCase("UInt32IConvertibleToBoolean");
        if (ui32ictbool.RunTests())
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
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        return retVal;
    }
    #region PositiveTest
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: genarate a random UInt32 to boolean 1");

        try
        {
            UInt32 uintA = (UInt32)this.GetInt32(1, Int32.MaxValue);
            IConvertible iConvert = (IConvertible)(uintA);
            if (!iConvert.ToBoolean(null))
            {
                TestLibrary.TestFramework.LogError("001","the ActualResult is not the ExpectResult");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: genarate a random UInt32 to boolean 2");

        try
        {
            UInt32 uintA = (UInt32)(this.GetInt32(1, Int32.MaxValue) + this.GetInt32(0, Int32.MaxValue));
            IConvertible iConvert = (IConvertible)(uintA);
            if (!iConvert.ToBoolean(null))
            {
                TestLibrary.TestFramework.LogError("003", "the ActualResult is not the ExpectResult");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: UInt32 MinValue to boolean");

        try
        {
            UInt32 uintA = UInt32.MinValue;
            IConvertible iConvert = (IConvertible)(uintA);
            if (iConvert.ToBoolean(null))
            {
                TestLibrary.TestFramework.LogError("005", "the ActualResult is not the ExpectResult");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest4()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest4: UInt32 MaxValue to boolean");

        try
        {
            UInt32 uintA = UInt32.MaxValue;
            IConvertible iConvert = (IConvertible)(uintA);
            if (!iConvert.ToBoolean(null))
            {
                TestLibrary.TestFramework.LogError("007", "the ActualResult is not the ExpectResult");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("008", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion
    #region ForTestObject
    private Int32 GetInt32(Int32 minValue, Int32 maxValue)
    {
        try
        {
            if (minValue == maxValue)
            {
                return minValue;
            }
            if (minValue < maxValue)
            {
                return minValue + TestLibrary.Generator.GetInt32(-55) % (maxValue - minValue);
            }
        }
        catch
        {
            throw;
        }

        return minValue;
    }
    #endregion
}
