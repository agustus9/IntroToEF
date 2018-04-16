using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntroToEF.Data;
namespace IntroToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Query Database
            var dbContext = new DataContext();

            var film = new Movies
            {
                Title = "Batman",
                YearReleased = 1985,
                Genre = "Action",
                Tagline = "Only one will claim the night.",
                Rating = 7

            };
            //dbContext.Movies.Add(film);
            

            var film2 = new Movies
            {
                Title = "The Lord of the Rings: The Return of the King",
                YearReleased = 2002,
                Genre = "Adventure",
                Tagline = "The eye of the enemy is moving.",
                Rating = 8

            };
            //dbContext.Movies.Add(film2);
            

            var film3 = new Movies
            {
                Title = "Gladiator",
                YearReleased = 1999,
                Genre = "Action",
                Tagline = "A Hero Will Rise.",
                Rating = 7

            };
            //dbContext.Movies.Add(film3);
            

            var film1988 = dbContext.Movies.Where(w => w.YearReleased == 1988);
            foreach (var movie in film1988)
            {
                movie.Rating = 10;
            }

            var endingStory = dbContext.Movies.Where(e => e.Title == "The NeverEnding Story");
            dbContext.Movies.RemoveRange(endingStory);

            var Horror = dbContext.Movies.Where(h => h.Genre == "Horror");
            foreach (var movie in Horror)
            {
                Console.WriteLine($"{movie.Title}");
            }

            dbContext.SaveChanges();
            Console.ReadLine();
        }
    }
}
