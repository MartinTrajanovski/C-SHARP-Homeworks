using Movie_Store_App_Domain_Models.Enums;
using Movie_Store_App_Domain_Models.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_Store_App_Services
{
    public class MovieService
    {
        public Movie[] Movies { get; set; }
        private static HelperService helperService = new HelperService();
        Movie[] AvailableMovies = new Movie[0];

        public MovieService()
        {
            Movies = new Movie[]
            {
                new Movie()
                {
                     Title = "The Death of Mr. Lazarescu",
                     Description = "A social satire about the Romanian health care system",
                     Year = 2005,
                     Genre = Genres.Drama,
                     IsRented = true
                },
                new Movie()
                {
                     Title = "The Apostle",
                     Description = "A character study of a Southern preacher whose undisturbed life suddenly spins out of control",
                     Year = 1997,
                     Genre = Genres.Drama,
                     IsRented = true
                },
                new Movie()
                {
                     Title = "Loveless",
                     Description = "A Russian drama about a couple stuck in a loveless marriage who has to join forces to look for their son who has vanished during one of their arguments",
                     Year = 2017,
                     Genre = Genres.Drama,
                     IsRented = true
                },
                new Movie()
                {
                     Title = "Amour",
                     Description = "A French octogenarian couple's love is tested after one of them suffers a stroke",
                     Year = 2012,
                     Genre = Genres.Drama,
                     IsRented = false
                },
                new Movie()
                {
                     Title = "Ida",
                     Description = "A Polish nun about to take her vows uncovers a family secret dating back to the German occupation",
                     Year = 2013,
                     Genre = Genres.Drama,
                     IsRented = false
                },
                new Movie()
                {
                     Title = "Cold War",
                     Description = "In the 1950s, a music director falls in love with a singer and tries to persuade her to flee communist Poland for France",
                     Year = 2018,
                     Genre = Genres.Drama,
                     IsRented = false
                },
            };
        }
        
        public void PrintAllMovies()
        {
            if (Movies.Length == 0)
            {
                Console.WriteLine("There are no animals in the shelter!");
                return;
            }
            else
            {
                foreach (Movie movie in Movies)
                {
                    if(movie.IsRented == false)
                    {
                        int ordinal = Array.IndexOf(Movies, movie);
                        Console.WriteLine($"{ordinal + 1}. {movie.Title}");
                    }
                }
            }
        }
        public void FindAvailableMovies()
        {
            if (Movies.Length == 0)
            {
                Console.WriteLine("There are no available movies!");
                return;
            }
            else
            {
                for (int i = 0; i < Movies.Length; i++)
                {
                    if (Movies[i].IsRented == false)
                    {
                        Array.Resize(ref AvailableMovies, AvailableMovies.Length + 1);
                        AvailableMovies[AvailableMovies.Length - 1] = Movies[i];
                    }
                }
                
            }
        }
        
        public void PrintAvailableMovies()
        {
            if (AvailableMovies.Length == 0)
            {
                Console.Clear();
                Console.WriteLine($"There are no available movies");
            } else
            {
                foreach (Movie movie in AvailableMovies)
                {
                    int ordinal = Array.IndexOf(AvailableMovies, movie);
                    Console.WriteLine($"{ordinal + 1}. {movie.Title}");
                }
            }
            
        }
        public Movie AddRentedMovies(int chosenMovie, User user)
        {
            Movie[] newarray = user.Movies;
            Array.Resize(ref newarray, newarray.Length + 1);
            newarray[newarray.Length - 1] = AvailableMovies[chosenMovie - 1];
            AvailableMovies[chosenMovie - 1].IsRented = true;
            user.Movies = newarray;
            return user.Movies[user.Movies.Length - 1];
        }
        public void PrintRentedMovies(User user)
        {
            if (user.Movies.Length == 0)
            {
                Console.Clear();
                Console.WriteLine($"You don't have any rented movies!");
            } else
            {
                foreach (Movie movie in user.Movies)
                {
                    int ordinal = Array.IndexOf(user.Movies, movie);
                    Console.WriteLine($"{ordinal + 1}. {movie.Title}");
                }
            }
        }
        public void ExcludeChosenMovie(int movieToRemove)
        {
            if (AvailableMovies.Length == 0)
            {
                Console.WriteLine("There are no available movies!");
                return;
            }
            else
            {
                AvailableMovies = AvailableMovies.Where((source, index) => index != movieToRemove - 1).ToArray();
            }
        }
        public void RentLogic(User user)
        {
            FindAvailableMovies();
            while (true)
            {
                Console.Clear();
                PrintAvailableMovies();
                if (AvailableMovies.Length == 0)
                {
                    break;
                }
                Console.WriteLine($"Please choose a film. Enter a number between 1 and {AvailableMovies.Length}");
                
                int chosenMovie = helperService.ValidatePositiveNumber(Console.ReadLine(), AvailableMovies.Length);
                if (chosenMovie >= 1 && chosenMovie <= AvailableMovies.Length)
                {
                    if (helperService.RunAgain() == true)
                    {
                        AddRentedMovies(chosenMovie, user);
                        ExcludeChosenMovie(chosenMovie);
                        if (AvailableMovies.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("There are no available movies to rent! These are your rented movies:");
                            PrintRentedMovies(user);
                            break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        AddRentedMovies(chosenMovie, user);
                        Console.WriteLine("These are your rented movies:");
                        PrintRentedMovies(user);
                        break;
                    }
                }
            }
        }
    }
}
