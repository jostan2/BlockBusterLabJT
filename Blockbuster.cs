using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLabJT
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        
        public void PrintMovies(List<Movie> Movies)
        {
            int index = 1;
            foreach (Movie Movie in Movies)
            {
                Console.WriteLine(index + ": " + Movie.Title);
                index++;
            }
        }

        public Movie CheckOut()
        {
            PrintMovies(Movies);
            Console.WriteLine("Which movies do you want to check out? Select the Index.");
            int movieInput = int.Parse(Console.ReadLine());
            Movie m = Movies[movieInput];
            PrintMovies(Movies);
            return m;
            
        }

        public bool Repeat()
        {
            Console.Write("Do you want to watch another movie? Y/N");
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    Console.WriteLine("Goodbye");
                    return false;
                }
                else
                {
                    Console.WriteLine("Please only enter Y or N:");
                }
            }
        }

        public bool PlayMovie(Movie choice)
        {
            Console.WriteLine($"Do you want to watch {choice.Title}? Y/N: ");
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    return true;
                    Console.WriteLine();
                }
                else if (input == "n")
                {
                    Console.WriteLine("Restarting program...");
                    return false;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please only enter y or n:");
                }
            }
        }
    }
}
