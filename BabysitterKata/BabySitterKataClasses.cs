using System;

namespace BabysitterKata
{

    public struct BabysittingStartTime
    {
        private int startingTime24H;

        public int StartingTime24H
        {
            get
            {
                return startingTime24H;
            }
            set
            {
                if ((value >= 17 && value <= 24) || (value >= 0 && value <= 3))
                    startingTime24H = value;
                else
                    throw new InvalidOperationException("The starting hour entered was somewhere outside the acceptable range of 5PM to 3AM, and is thus invalid.");
            }
        }
    }

    public struct BabysittingEndTime
    {
        private int endingTime24H;

        public int EndingTime24H
        {
            get
            {
                return endingTime24H;
            }
            set
            {
                if ((value >= 18 && value <= 24) || (value >= 0 && value <= 4))
                    endingTime24H = value;
                else
                    throw new InvalidOperationException("The ending hour entered was somewhere outside the acceptable range of 6PM to 4AM, and is thus invalid.");
            }
        }
    }

    public class OneNightSchedule
    {
        public BabysittingStartTime StartingTime;

        public BabysittingEndTime EndingTime;
    }
}
