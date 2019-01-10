using System;
using System.Collections.Generic;
using System.Text;

namespace BabysitterKata
{
    public class ScheduleIntervalRate
    {
        public ScheduledInterval TimeRangeForRate;
        public int RateInDollars;
    }

     public class FamilyRateRangeList
    {
        internal List<ScheduleIntervalRate> _familyRateRanges;

        public List<ScheduleIntervalRate> FamilyRateRanges
        {
            get { return _familyRateRanges; }
        }
    }


    public class FamilyARateRangeList : FamilyRateRangeList
    {
        public FamilyARateRangeList()
        {
            _familyRateRanges = new List<ScheduleIntervalRate>()
            {
                //Family A pays $15 per hour before 11pm
                new ScheduleIntervalRate()
                {
                    RateInDollars = 15,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        EndingTime24H = 23,
                    }
                },

                //Family A pays $20 per hour the rest of the night
                new ScheduleIntervalRate()
                {
                    RateInDollars = 20,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        StartingTime24H = 23
                    }
                },
            };
        }
    }

    public class FamilyBRateRangeList : FamilyRateRangeList
    {
        public FamilyBRateRangeList()
        {
            _familyRateRanges = new List<ScheduleIntervalRate>()
            {
                //Family B pays $12 per hour before 10pm
                new ScheduleIntervalRate()
                {
                    RateInDollars = 12,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        EndingTime24H = 22,
                    }
                },

                //Family B pays $8 between 10 and 12,
                new ScheduleIntervalRate()
                {
                    RateInDollars = 8,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        StartingTime24H = 22,
                        EndingTime24H = 24
                    }
                },

                //Family B pays $16 the rest of the night,
                new ScheduleIntervalRate()
                {
                    RateInDollars = 16,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        StartingTime24H = 24,
                    }
                },
            };
        }
    }

    public class FamilyCRateRangeList : FamilyRateRangeList
    {
        public FamilyCRateRangeList()
        {
            _familyRateRanges = new List<ScheduleIntervalRate>()
            {
                //Family A pays  $21 per hour before 9pm
                new ScheduleIntervalRate()
                {
                    RateInDollars = 21,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        EndingTime24H = 21,
                    }
                },

                //Family A pays $15 per hour the rest of the night
                new ScheduleIntervalRate()
                {
                    RateInDollars = 15,
                    TimeRangeForRate = new ScheduledInterval()
                    {
                        StartingTime24H = 21
                    }
                },
            };
        }
    }
}
