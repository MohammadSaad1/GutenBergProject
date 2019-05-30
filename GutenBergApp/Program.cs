using GutenBergApp.Models;
using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutenBergApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient(new MongoUrl("mongodb://localhost:27017"));
            var database = client.GetDatabase("GutenbergProjectDB");
            var collection = database.GetCollection<Book>("Books");


            //    collection.Find()
            //  var findByName = collection.Find(x => x.Author.Contains("John")).Limit(10).ToList();
            String output;
            Console.WriteLine("Do you want to search by author, coordinates, city or booktitle?");
            output = Console.ReadLine();
            if (output.ToLower() == "author")
            {
                Console.WriteLine("Name an author");
                output = Console.ReadLine();
                authorSearchReturnsBooksOnMap(output, collection);
            }
            else if (output.ToLower() == "city")
            {
                Console.WriteLine("Name a city");
                output = Console.ReadLine();
                citySearchReturnsBooks(output, collection);
            }
            if (output.ToLower() == "booktitle")
            {
                Console.WriteLine("Name a book");
                output = Console.ReadLine();
                bookSearchReturnsBooksOnMap(output, collection);
            }
            if (output.ToLower() == "coordinates")
            {
                Console.WriteLine("Sorry, this doesn't work atm.");
            }



            Console.ReadLine();

        }

        public static void citySearchReturnsBooks(string City, IMongoCollection<Book> collection)
        {
            var findByCity = collection.Find(Builders<Book>.Filter.ElemMatch(x => x.CitiesInBook, b => b.CityName == City)).ToList();
            foreach (var item in findByCity)
            {
                Console.WriteLine(item.Title);
            }
        }


        public static void bookSearchReturnsBooksOnMap(string BookTitle, IMongoCollection<Book> collection)
        {
            string link = "https://www.google.com/maps/dir";
            var MapPinPointByAuthor = collection.Find(x => x.Title.Contains(BookTitle)).ToList();

            for (int j = 0; j < MapPinPointByAuthor.ToArray().Length; j++)
                for (int i = 0; i < MapPinPointByAuthor[j].CitiesInBook.ToArray().Length; i++)
                {
                    if (i == MapPinPointByAuthor[j].CitiesInBook.ToArray().Length - 1)
                    {
                        link += $"//@{MapPinPointByAuthor[j].CitiesInBook[i].Long.Replace(",", ".")},{MapPinPointByAuthor[j].CitiesInBook[i].Lat.Replace(",", ".")}, 10.57z";
                        Console.WriteLine("Default browser opens with pinpointed cities which is mentioned in" + BookTitle + ". Click on any button...");
                        Console.ReadLine();
                        System.Diagnostics.Process.Start(link);

                    }
                    else
                    {
                        link += $"/{MapPinPointByAuthor[j].CitiesInBook[i].Long.Replace(",", ".")},{MapPinPointByAuthor[j].CitiesInBook[i].Lat.Replace(",", ".")}";
                    }
                }
        }

        public static void authorSearchReturnsBooksOnMap(string Author, IMongoCollection<Book> collection)
        {
            var MapPinPointByAuthor = collection.Find(x => x.Author.Contains(Author)).ToList();
            string link = "https://www.google.com/maps/dir";

            for (int j = 0; j < MapPinPointByAuthor.ToArray().Length; j++)
                for (int i = 0; i < MapPinPointByAuthor[j].CitiesInBook.ToArray().Length; i++)
                {
                    if (i == MapPinPointByAuthor[j].CitiesInBook.ToArray().Length - 1)
                    {
                        link += $"//@{MapPinPointByAuthor[j].CitiesInBook[i].Long.Replace(",", ".")},{MapPinPointByAuthor[j].CitiesInBook[i].Lat.Replace(",", ".")}, 10.57z";
                        Console.WriteLine(link);
                        Console.WriteLine("Default browser opens with pinpointed cities which is mentioned in the books of" + Author + ". Click on any button...");

                        Console.ReadLine();
                        System.Diagnostics.Process.Start(link);

                    }
                    else
                    {
                        link += $"/{MapPinPointByAuthor[j].CitiesInBook[i].Long.Replace(",", ".")},{MapPinPointByAuthor[j].CitiesInBook[i].Lat.Replace(",", ".")}";
                    }
                }
        }



        public static void returnNeighbours(IMongoCollection<Book> collection)
        {
            var point = GeoJson.Point(new GeoJson2DGeographicCoordinates(145.889, -35.831));
            int maxDistance = 300;


            /* var cursor = collection.FindSync(new FilterDefinitionBuilder<Book>().Near(x => x.CitiesInBook.ElementAt(-1).Location, point, maxDistance: maxDistance)).ToList();

                 foreach (var item in cursor)
                 {
                     Console.WriteLine(item.Title);
                 }
             }


         */
        
        }
    }
}