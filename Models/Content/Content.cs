using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviESWeb.Models.Content
{
    public abstract class Content
    {
        private int id;
        private string title;
        private string category;
        private int rating;
        private int numOfRates;

        public Content(int idFilm, string title, string category)
        {
            Id = idFilm;
            Title = title;
            Category = category;
            Rating = 0;// rating between 0 and 5
            NumOfRates = 0;// var for calculating rating
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        public int Rating { get => rating; set => rating = value; }
        public int NumOfRates { get => numOfRates; set => numOfRates = value; }
    }
}
