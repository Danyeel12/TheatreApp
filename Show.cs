using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_App
{
    internal class Show
    {
        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        //Constructor
        public Show(Movie movie, Time time, DayEnum day, double price)
        {            
            Movie = movie;
            Time = time;
            Day = day;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Day} {Time} {Movie} ${string.Join(", ", Price)}";
        }
    }
}
