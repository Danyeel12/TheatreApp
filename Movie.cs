using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_App
{
    internal class Movie
    {
        //Properties
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; } //modified by SetGenre(Genre genre)
        public List<string> Cast { get; }

        //Constructor
        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
            Cast = new List<string>();
        }

        //Methods
        public void AddActor(string actor) //adds a single a string to the collection of actors (Cast)
        {
            Cast.Add(actor);
        }
        public void SetGenre(GenreEnum genre)//maybe a combination of multiple genres
        {
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} {Year} {Length} min ({Genre}) {string.Join(", ", Cast)}";
        }
    }
}
