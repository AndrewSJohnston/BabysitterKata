using BabysitterKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BabySitterKataUnitTests
{
    [TestClass]
    public class BabySitterNightlyPayValidationTests
    {
        [TestMethod]
        public void FamilyAFullNightRateTest()
        {

            var nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval(), new FamilyARateRangeList());

            Assert.IsTrue(nightlyPay == 0);
        }
    }
}
