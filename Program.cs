using System;

namespace BlockbusterLabJT
{ //due AM friday 10/14/22
    public class Program
    {
        public static void Main()
        {
            Blockbuster info = new Blockbuster(); // links info with Blockbuster.cs
            

            bool start = true;
            while (start == true)
            {
                List<Movie> Movies = new List<Movie>(); //uses parameters listed in Movie.cs to creat a list
                {
                    Movies.Add(new DVD("DVD1", Genre.Comedy, 90, new List<string> { "Scene 1", "Scene 2", "Scene 3" }));
                    Movies.Add(new DVD("DVD2", Genre.Horror, 900, new List<string> { "Year 1", "Year 2", "Year 3", "Year 4", "Year 666" }));
                    Movies.Add(new DVD("DVD3", Genre.Action, 45, new List<string> { "Chapter 1", "Chapter 2", "Chapter 3", "Chapter 4" }));
                    Movies.Add(new VHS("VHS1", Genre.Romance, 15, new List<string> { "Moving Picture 1", "Moving Picture 2", "Moving Picture 3" }));
                    Movies.Add(new VHS("VHS2", Genre.Action, 100, new List<string> { "Launch 1", "Ascent 2", "Orbit 3", "Zenith 4", "Nadir 5" }));
                    Movies.Add(new VHS("VHS3", Genre.Drama, 160, new List<string> { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5", "Book 6", "Book 7", }));

                }

                Console.WriteLine("Welcome to Blockbuster"); Console.WriteLine();

               

                


                int userInput = -1;
                Movie choice;
                while (userInput == -1)
                {
                    try
                    {
                        Console.WriteLine("Available Movies"); Console.WriteLine("--------------------------------");
                        info.PrintMovies(Movies); Console.WriteLine(); //uses PrintMovies method from Blockbuster.cs to display list of movies.
                        Console.Write("Please select a movie from the list to watch: ");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput > 0 && userInput <= Movies.Count)
                        {
                            choice = Movies[userInput - 1];
                            Console.WriteLine();
                            choice.PrintInfo();
                        }
                        else
                        {
                            Console.WriteLine($"Your input was not a valid number, please try again. Enter a number between 1-{Movies.Count}.");
                            Console.WriteLine();
                            continue;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("That wasnt an index in our system! Try again");
                        Console.WriteLine();
                        continue;
                    }

                    Console.WriteLine();

                    if (info.PlayMovie(choice) == true)
                    {
                        choice.Play();
                    }

                    //



                    Console.WriteLine();
                    start = info.Repeat();
                }
            }         
        }       
    }
}