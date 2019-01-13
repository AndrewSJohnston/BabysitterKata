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
        public void FamilyANightRateTests()
        {
            var familyRateRange = new FamilyARateRangeList();

            //Test Full night with family A | 15$ per hour for 6 hours between 5pm and 11pm = 90, 20$ hour for 5 hours between 11pm and 4am = 100
            var nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval(), familyRateRange);
            Assert.IsTrue(nightlyPay == 190);

            //Test night with family A overlapping both pay rate schedules | 15$ per hour for 1 hour between 10pm and 11pm, 
            //20$ hour for 2 hours between 11pm and 1am = 55
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 1,
                                                                                                    StartingTime24H = 22
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 55);

            //Test night with family A all hours in first pay rate window | 15$ per hour for 3 hour between 6pm and 9pm = 45
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 21,
                                                                                                    StartingTime24H = 18
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 45);

            //Test night with family A all hours in second pay rate window | 20$ per hour for 4 hours between 12pm and 4am = 80 
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 4,
                                                                                                    StartingTime24H = 24
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 80);
        }

        [TestMethod]
        public void FamilyBNightRateTests()
        {
            var familyRateRange = new FamilyBRateRangeList();
            //Test Full night with family B | $12 per hour before 10pm, $8 between 10 and 12, and $16 the rest of the night = 140
            var nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval(), familyRateRange);
            Assert.IsTrue(nightlyPay == 140);

            //Test night with family B overlapping all pay rate schedules | 12$ per hour for 1 hour between 9pm and 10pm 
            //8$ hour for 2 hours between 10pm and 12pm and 16$ for 2 hours between 12pm and 2am = 60
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 2,
                                                                                                    StartingTime24H = 21
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 60);

            //Test night with family B all hours in first pay rate window | 12$ per hour for 4 hours between 5pm and 9pm = 48 
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 21,
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 48);

            //Test night with family B all hours in second pay rate window | 8$ hour for 1 hours between 10pm and 11pm = 8 
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 23,
                                                                                                    StartingTime24H = 22
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 8);

            //Test night with family B all hours in third pay rate window | $16 hour for 3 hours between 1am and 4am = 48 
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 4,
                                                                                                    StartingTime24H = 1
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 48);

            //Test night with family B overlapping first two pay rate schedules | 12$ per hour for 2 hours between 8pm and 10pm, 
            //8$ hour for 1 hour between 10pm and 11pm = 32
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 23,
                                                                                                    StartingTime24H = 20
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 32);



            //Test night with family B overlapping final two pay rate schedules | 8$ per hour for 1 hour between 11pm and 12pm, 
            //16$ hour for 4 hours between 12am and 4am = 72
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
            {
                StartingTime24H = 23
            },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 72);
        }

        [TestMethod]
        public void FamilyCNightRateTests()
        {
            var familyRateRange = new FamilyCRateRangeList();

            //Test Full night with family C | 21$ per hour for 4 hours between 5pm and 9pm, 15$ hour for 7 hours between 9pm and 4am = 195
            var nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval(), familyRateRange);
            Assert.IsTrue(nightlyPay == 189);

            //Test night with family C overlapping both pay rate schedules | 21$ per hour for 2 hours between 7pm and 9pm, 
            //15$ hour for 3 hours between 9pm and 12am = 87
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 24,
                                                                                                    StartingTime24H = 19
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 87);

            //Test night with family C all hours in first pay rate window | 21$ per hour for 4 hours between 5pm and 9pm = 84
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 21
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 84);

            //Test night with family C all hours in second pay rate window | 15$ per hour for 5 hours between 11pm and 4am = 75 
            nightlyPay = NightlyTotalPayCalculator.CalculateAmountOwedForGivenNightlySchedule(new ScheduledInterval()
                                                                                                {
                                                                                                    EndingTime24H = 4,
                                                                                                    StartingTime24H = 23
                                                                                                },
                                                                                              familyRateRange);
            Assert.IsTrue(nightlyPay == 75);
        }
    }
}
