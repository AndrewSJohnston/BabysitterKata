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
                        StartingTime24 = 23
                    }
                },
            };
        }
    }

    public class FamilyBRateRangeList
    {
        private List<ScheduleIntervalRate> _familyRateRanges;

        public FamilyBRateRangeList()
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
                        StartingTime24 = 23
                    }
                },
            };
        }

        public List<ScheduleIntervalRate> FamilyRateRanges
        {
            get { return _familyRateRanges; }
        }
    }
}
