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

    public class FamilyARateRangeList
    {
        private List<ScheduleIntervalRate> _familyRateRanges;

        public FamilyARateRangeList()
        {
            _familyRateRanges = new List<ScheduleIntervalRate>();
        }

        public List<ScheduleIntervalRate> FamilyRateRanges
        {
            get { return _familyRateRanges; }
        }
    }
}
