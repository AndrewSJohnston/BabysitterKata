using BabysitterKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BabySitterKataUnitTests
{
    [TestClass]
    public class BabysitterScheduleTimeValidationTests
    {
        List<int> validStartTimes = new List<int>();
        List<int> validEndTimes = new List<int>();

        [TestInitialize()]
        public void Setup()
        {
            for (var x = 17; x <= 24; x++)
            {
                validStartTimes.Add(x);
            }

            for (var x = 1; x <= 3; x++)
            {
                validStartTimes.Add(x);
            }

            for (var x = 18; x <= 24; x++)
            {
                validEndTimes.Add(x);
            }

            for (var x = 1; x <= 4; x++)
            {
                validEndTimes.Add(x);
            }
        }

        #region Start and End Time Validation

        #region Start Time Validation

        public void TestTimeRange(int x, bool isStartTime = false, bool testIfValid = false)
        {
            try
            {
                var schedule = new ScheduledInterval()
                {
                    StartingTime24H = isStartTime ? x : 17,
                    EndingTime24H = !isStartTime ? x : 4,
                };
            }
            catch (Exception e)
            {
                if (testIfValid)
                    Assert.Fail();
                else
                    return;
            }

            if (!testIfValid)
                Assert.Fail();
        }

        [TestMethod]
        public void NightScheduleAcceptsValidStartingTime()
        {
            foreach (var validValue in validStartTimes)
            {
                TestTimeRange(validValue, true, true);
            }
        }

        [TestMethod]
        public void NightScheduleFailsWithInvalidStartingTime()
        {
            for (var x = -48; x <= 48; x++)
            {
                if (!validStartTimes.Contains(x))
                    TestTimeRange(x, true);
            }
        }

        #endregion

        #region End Time Validation

        [TestMethod]
        public void NightScheduleAcceptsValidEndingTime()
        {
            foreach (var validValue in validEndTimes)
            {
                TestTimeRange(validValue, false, true);
            }
        }

        [TestMethod]
        public void NightScheduleFailsWithInvalidEndingTime()
        {
            for (var x = -48; x <= 48; x++)
            {
                if (!validEndTimes.Contains(x))
                    TestTimeRange(x);
            }
        }
        #endregion
    }

    #endregion
}
