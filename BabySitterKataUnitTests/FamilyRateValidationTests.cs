using BabysitterKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BabySitterKataUnitTests
{
    [TestClass]
    public class FamilyRateValidationTests
    {
        [TestMethod]
        public void FamilyARateValidation()
        {
            var familyARates = new FamilyARateRangeList();

            //Make sure all the rate ranges match the spec
            Assert.IsTrue(familyARates.FamilyRateRanges.All(a => (a.RateInDollars == 15 
                                                                    && a.TimeRangeForRate.StartingTime24 == 17 
                                                                    && a.TimeRangeForRate.EndingTime24H == 23)
                                                                || (a.RateInDollars == 20
                                                                    && a.TimeRangeForRate.StartingTime24 == 23
                                                                    && a.TimeRangeForRate.EndingTime24H == 4)));
        }

        [TestMethod]
        public void FamilyBRateValidation()
        {
            var familyBRates = new FamilyBRateRangeList();

            //Make sure all the rate ranges match the spec
            Assert.IsTrue(familyBRates.FamilyRateRanges.All(a => (a.RateInDollars == 12
                                                                    && a.TimeRangeForRate.StartingTime24 == 17
                                                                    && a.TimeRangeForRate.EndingTime24H == 22)
                                                                || (a.RateInDollars == 8
                                                                    && a.TimeRangeForRate.StartingTime24 == 22
                                                                    && a.TimeRangeForRate.EndingTime24H == 24)
                                                                || (a.RateInDollars == 16
                                                                    && a.TimeRangeForRate.StartingTime24 == 24
                                                                    && a.TimeRangeForRate.EndingTime24H == 4)));
        }

        [TestMethod]
        public void FamilyCRateValidation()
        {
            var familyCRates = new FamilyCRateRangeList();

            //Make sure all the rate ranges match the spec
            Assert.IsTrue(familyCRates.FamilyRateRanges.All(a => (a.RateInDollars == 21
                                                                    && a.TimeRangeForRate.StartingTime24 == 17
                                                                    && a.TimeRangeForRate.EndingTime24H == 21)
                                                                || (a.RateInDollars == 15
                                                                    && a.TimeRangeForRate.StartingTime24 == 21
                                                                    && a.TimeRangeForRate.EndingTime24H == 4)));
        }
    }
}