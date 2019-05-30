using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutenBergApp.Models
{
  public  class Book
    {
        public ObjectId _id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public List<City> CitiesInBook { get; set; }

        public Book(string title, string author, List<City> citiesinBook)
        {
            Title = title;
            Author = author;
            CitiesInBook = citiesinBook;    
        }

        

    }
}
