using BabysitterKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BabySitterKataUnitTests
{
    [TestClass]
    public class BabysitterScheduleTimeValidationTests
    {
        #region Start and End Time Validation

        #region Start Time Validation

        [TestMethod]
        public void NightScheduleAcceptsValidStartingTime()
        {
            try
            {
                var schedule = new ScheduledInterval()
                {
                    StartingTime24H = 17,
                };
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void NightScheduleFailsWithInvalidStartingTime()
        {
            try
            {
                var schedule = new ScheduledInterval()
                {
                    StartingTime24H = 12,
                };
            }
            catch (Exception e)
            {
               return;
            }

            Assert.Fail();
        }

        #endregion

        #region End Time Validation

        [TestMethod]
        public void NightScheduleAcceptsValidEndingTime()
        {
            try
            {
                var schedule = new ScheduledInterval()
                {
                    EndingTime24H = 18,
                };
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void NightScheduleFailsWithInvalidEndingTime()
        {
            try
            {
                var schedule = new ScheduledInterval()
                {
                    EndingTime24H = 12,
                };
            }
            catch (Exception e)
            {
                return;
            }
            Assert.Fail();
        }
        #endregion
    }

    #endregion
}
