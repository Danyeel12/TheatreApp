using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_App
{
    internal class Time
    {
        //Properties
        public int Hours { get; }
        public int Minutes { get; }
        const int MAX_GAP_MIN = 15;
        const int MIN_PER_HOUR = 60;

        //Constructor
        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }

        //Methods
        public override string ToString()
        {
            return $"{Hours}:{Minutes:d2}";
        }

        public static bool operator ==(Time lhs, Time rhs)//e.g. if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary) { return true; }
                                                          //else { return false; }                                                          
        {
            int timeinminsL = lhs.Hours * MIN_PER_HOUR + lhs.Minutes;
            int timeinminsR = rhs.Hours * MIN_PER_HOUR + rhs.Minutes;
            return Math.Abs(timeinminsL - timeinminsR) <= MAX_GAP_MIN;

        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            int timeinminsL = lhs.Hours * MIN_PER_HOUR + lhs.Minutes;
            int timeinminsR = rhs.Hours * MIN_PER_HOUR + rhs.Minutes;
            return Math.Abs(timeinminsL - timeinminsR) <= MAX_GAP_MIN;
        }
    }
}
