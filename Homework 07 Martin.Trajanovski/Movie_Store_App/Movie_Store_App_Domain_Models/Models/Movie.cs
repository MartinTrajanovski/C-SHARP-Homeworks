using Movie_Store_App_Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Domain_Models.Members
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year  { get; set; }
        public Genres Genre { get; set; }
        public bool IsRented { get; set; }
        private int Price { get; set; }
        public Movie()
        {

        }
        public Movie(string title, string description, int year, Genres genre, bool isRented)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            IsRented = isRented;
        }
        public int SetPrice()
        {
            Random randomPrice = new Random();
            if (Year < 2000)
            {
               return Price = randomPrice.Next(100, 201);
            } else if (Year >= 2000 && Year <= 2010)
            {
               return Price = randomPrice.Next(200, 301);
            } else
            {
               return Price = randomPrice.Next(200, 501);
            }
        }
    }
}
