using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabysitterKata
{
    public static class NightlyTotalPayCalculator
    {
        //For the morning hours, ie 1am through 4 am, simple add 24 to help when calculating sequential hours worked
        static public int ScheduleHourTransform(int actualHour)
        {
            var scheduleHourNo = actualHour;
            if (scheduleHourNo > 0 && scheduleHourNo <= 4)
                scheduleHourNo += 24;

            return scheduleHourNo;
        }

        static public int CalculateAmountOwedForGivenNightlySchedule(ScheduledInterval BabysittingSchedule, FamilyRateRangeList givenFamilyRates)
        {
            var dollarAmountOwed = 0;
            var actualStartingTime = ScheduleHourTransform(BabysittingSchedule.StartingTime24H);
            var actualEndingTime = ScheduleHourTransform(BabysittingSchedule.EndingTime24H);
            for (var x = ++actualStartingTime; x <= actualEndingTime; x++)
            {
                //Find which range the current hour is in
                var applicableRate = givenFamilyRates.FamilyRateRanges.Single(a => x > ScheduleHourTransform(a.TimeRangeForRate.StartingTime24H)
                                                                                    && x <= ScheduleHourTransform(a.TimeRangeForRate.EndingTime24H))
                                                                      .RateInDollars;

                dollarAmountOwed += applicableRate;
            }

            return dollarAmountOwed;
        }
    }
}
