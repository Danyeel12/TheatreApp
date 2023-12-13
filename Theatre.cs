using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_App
{
    internal class Theatre
    {
        //Fields
        private List<Show> shows;
        //Properties
        public string Name { get; }
        //Construotor
        public Theatre(string name)//Q-a: Assigns the argument to the appropriate property, Q-b: Initialize the "Shows" property to a new list of show
        {
            Name = name;              //A-a 
            shows = new List<Show>();  //A-b
        }
        //Methods
        public void AddShow(Show show)//Q: This public method takes a show object and adds to the collection of shows
        {
            shows.Add(show);//A:     //Similar code can be find in Week05code's McDonalds
                            //e.g. duties = new List<string>(){"duty1", ..., "duty10"}
                            //e.g. duteis.Add("duty11")
        }

        public void PrintShows()//Q: No argument, no return, display all the shows that is available in the shows collection
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine("All shows");
            Console.WriteLine("=============");
            foreach (var show in shows)
            {
                Console.WriteLine(show);    //after typing "foreach",
                                            //"Tab" button twice generate this code >>>(var item in collection)
                                            //"foreach" "space" "var" generate >>(var show in shows) (Console.WriteLine(show)
            }
        }
        public void PrintShows(GenreEnum genre)//Q: "Genre" as argument, display all ths show contains the "flag" of this genre
                                               //,use "instance method" "HasFlags()".
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{genre} movie");
            Console.WriteLine("=============");
            foreach (var show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))//*nothing close to that...*
                {
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(DayEnum day)//Q: takes a Day object as an argument,
                                           //display all the shows matching this day object 
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{day} on Sun");
            Console.WriteLine("=============");
            foreach (var show in shows)
            {
                if (show.Day == day)
                {
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(Time time)//Q: time object = argument, display all shows match hour value,
                                         //only work if == operator is implemented correctly in the Time class. 
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{time} @14:05");
            Console.WriteLine("=============");
            foreach (var show in shows)
            {
                if (show.Time == time) Console.WriteLine(show);
            }
        }
        public void PrintShows(string actor)//actors are stored as a List<string>
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{actor} movies");
            Console.WriteLine("=============");
            foreach (var show in shows)
            {
                if (show.Movie.Cast.Contains(actor)) Console.WriteLine(show);
            }
        }
        public void PrintShows(DayEnum day, Time time)//numeric values of the fields of the two objects must be compared
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{day} movies @14:05");
            Console.WriteLine("=============");
            foreach (var show in shows)
            {
                if (show.Time == time && show.Day == day) Console.WriteLine(show);
            }
        }
    }
}
