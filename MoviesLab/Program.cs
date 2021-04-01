using System;
using System.Collections.Generic;
namespace Movies
{
    class Movie
    {

        // Member variables
        public string Title;
        public string Category;


        // Constructor
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;

        }
        // Member methods/functions
        public void PrintOut()
        {
            Console.WriteLine(Title);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            MovieSelection();



        }





        public static void MovieSelection()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie("The Abyss", "Sci Fi"));
            Movies.Add(new Movie("Silent Running", "Sci Fi"));
            Movies.Add(new Movie("365 days", "Romantic"));
            Movies.Add(new Movie("50 1st Date", "Romantic"));
            Movies.Add(new Movie("The Gentlemen", "Comedy"));
            Movies.Add(new Movie("Buddy Games", "Comedy"));
            Movies.Add(new Movie("Lou", "Animated"));
            Movies.Add(new Movie("Chicken Run", "Animated"));
            Movies.Add(new Movie("Underwater", "Horror"));
            Movies.Add(new Movie("Persuit of Happiness", "Drama"));

            bool cont = false;

            while (cont != true)
            {


                Console.WriteLine($"There are {Movies.Count} Movies in the list");

                Console.WriteLine("Which Category do you want to browse? ");
                string userInput = Console.ReadLine().ToLower();
                int chek = 0;
                int check2 = 0;


                foreach (Movie movieList in Movies)
                {


                    //Console.WriteLine(movieList.Category);
                    if (movieList.Category.ToLower() == userInput)
                    {
                        if (check2 == 0)
                        {
                            Console.WriteLine($"Movie Title          ||||               Category  ");
                        }

                        chek = 1;
                        check2 = 1;
                        Console.WriteLine(movieList.Title + "                             " + movieList.Category);
                    }


                }

                if (chek == 0)
                {
                    Console.WriteLine("Sorry invalid Category");
                }

                Console.WriteLine("Continue (y/n");
                string yn = Console.ReadLine();

                if (yn == "n")
                {
                    cont = true;
                }


            }
        }

    }
}
