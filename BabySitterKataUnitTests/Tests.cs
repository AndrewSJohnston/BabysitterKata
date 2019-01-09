using BabysitterKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BabySitterKataUnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void NightScheduleAcceptsValidStartingTime()
        {
            try
            {
                var schedule = new OneNightSchedule()
                {
                    StartingTime = new BabysittingStartTime()
                    {
                        StartingTime24H = 17
                    },
                };
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void NightScheduleFailsWithInValidStartingTime()
        {
            try
            {
                var schedule = new OneNightSchedule()
                {
                    StartingTime = new BabysittingStartTime()
                    {
                        StartingTime24H = 12
                    },
                };
            }
            catch (Exception e)
            {
               return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void NightScheduleAcceptsValidEndingTime()
        {
            try
            {
                var schedule = new OneNightSchedule()
                {
                    EndingTime = new BabysittingEndTime()
                    {
                        EndingTime24H = 18
                    },
                };
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void NightScheduleFailsWithInValidEndingTime()
        {
            try
            {
                var schedule = new OneNightSchedule()
                {
                    EndingTime = new BabysittingEndTime()
                    {
                        EndingTime24H = 18
                    },
                };
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}
