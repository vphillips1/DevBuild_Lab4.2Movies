using System;
using System.Collections.Generic;

namespace Lab4._2Movies
{


    public class Movie
    {
        public string category;
        public string title;

        public Movie(string acategory, string atitle)
        {
            category = acategory;
            title = atitle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Application!\n");

            Console.WriteLine("There are 10 movies in this list.");


            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Drama", "Bombshell"));
            movies.Add(new Movie("Drama", "Serenity"));
            movies.Add(new Movie("Animated", "Moana"));
            movies.Add(new Movie("Animated", "Frozen"));
            movies.Add(new Movie("Drama", "Bombshell"));
            movies.Add(new Movie("Horror", "Insidious"));
            movies.Add(new Movie("Horror", "The Grudge"));
            movies.Add(new Movie("Scifi", "The New Mutants"));
            movies.Add(new Movie("Scifi", "Gemini Man"));
            movies.Add(new Movie("Horror", "Escape Room"));


            bool again = true;
           
            while (again)
            {
                bool contloop = true;
                do
                {
                    Console.WriteLine("What category are you interested in?");
                    string userSelection = Console.ReadLine();


                    foreach (var movieList in movies)
                    {

                        if (movieList.category.Equals(userSelection, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"{movieList.title}");
                            contloop = false;
                           
                        }                        
                        
                    }
                    if(contloop == true)
                    {
                        Console.WriteLine("That category does not exist");
                    }

                } while (contloop);
               
                                   
                                          
                bool shouldContinue = true;

                while (shouldContinue)
                {
                    Console.WriteLine("Continue? (y/n)");
                    string response = Console.ReadLine().ToLower();

                    if (response == "y" || response == "yes")
                    {
                        shouldContinue = false;
                        again = true;

                    }
                    else if (response == "n" || response == "No")
                    {                      
                        Console.WriteLine("Have a great day!");
                        shouldContinue = false;
                        again = false;
                    }
                    else
                    {
                       Console.WriteLine("Please enter a valid selection");
                        shouldContinue = true;
                    }


                }
                             
                                                   

            }


        }
    }


}
