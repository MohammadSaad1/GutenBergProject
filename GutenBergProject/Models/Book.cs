using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutenBergProject.Models
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public List<City> CitiesInBook { get; set; }
        

    }
}
