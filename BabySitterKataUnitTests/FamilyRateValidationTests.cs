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
    }
}