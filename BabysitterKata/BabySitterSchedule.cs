using System;

namespace BabysitterKata
{
    public class ScheduledInterval
    {
        int _startingTime24H;
        int _endingTime24H;
        public ScheduledInterval()
        {
            _startingTime24H = 17;
            _endingTime24H = 4;
        }

        public int StartingTime24H
        {
            get { return _startingTime24H; }
            set
            {
                //Arrives anywhere between 5:00PM and 3:00AM
                if ((value >= 17 && value <= 24) || (value > 0 && value <= 3))
                    _startingTime24H = value;
                else
                    throw new InvalidOperationException("The starting hour entered was somewhere outside the acceptable range of 5PM to 3AM, and is thus invalid.");
            }
        }

        public int EndingTime24H
        {
            get { return _endingTime24H; }
            set
            {
                //Leaves anywhere between 6:00PM and 4:00AM
                if ((value >= 18 && value <= 24) || (value > 0 && value <= 4))
                    _endingTime24H = value;
                else
                    throw new InvalidOperationException("The ending hour entered was somewhere outside the acceptable range of 6PM to 4AM, and is thus invalid.");
            }
        }
    }
}
