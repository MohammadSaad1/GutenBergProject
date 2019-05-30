using edu.stanford.nlp.ie.crf;
using GutenBergProjectApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GutenbergReader
{
    public class FileReader
    {
        static int i;

        public List<Book> getStreamFromTxtFile(String folderPath)
        {
            String fileContent = "";
            List<string> apts = new List<string>();
            DirectoryInfo d = new DirectoryInfo(folderPath);
            HashSet<City> cities = new HashSet<City>();
             List<Book> books = new List<Book>();
            var client = new MongoClient(new MongoUrl("mongodb://localhost:27017"));
            var database = client.GetDatabase("GutenbergProjectDB");
            var collection = database.GetCollection<Book>("BooksNew");
           

            FileInfo[] Files = d.GetFiles("*.txt");



            // Path to the folder with classifiers models 
            var jarRoot = "stanford-ner-2016-10-31";
            var classifiersDirecrory = jarRoot + @"\classifiers";

            // Loading 3 class classifier model
            var classifier = CRFClassifier.getClassifierNoExceptions(
                classifiersDirecrory + @"\english.all.3class.distsim.crf.ser.gz");

            string worldcities = System.IO.File.ReadAllText("/worldcities.csv");



            foreach (var file in Files)
            {


                string content = System.IO.File.ReadAllText(folderPath + "//" + file);


                var locations = classifier.classifyToString(content).Split('.', ' ', ',', '-', ':').Where(x => x.Contains("/LOCATION"));

                foreach (var item in locations)
                {
                    if (item.Contains("/LOCATION") && !item.Contains("/O"))
                    {
                        var newItem = item.Replace("/LOCATION", "");
                        var splittedArray = worldcities.Split('\n').Where(x => x.Contains(newItem.Trim())).ToArray();

                        if (splittedArray.Length > 0)
                        {
                            foreach (var row in splittedArray)
                            {
                                var currentRow = row.Split(';').ToArray();
                                if (currentRow.Length > 2)
                                {
                                    if (currentRow[2].Trim() == newItem.Trim())
                                    {
                                        cities.Add(new City(newItem, currentRow[3], currentRow[4]));
                                        break;
                                    }
                                }


                            }
                        }

                    }
                }

                var vs = content.Split('\n').Where(x => x.Contains("Title:") || x.Contains("Author:")).ToArray();

                if(2 == vs.Length)
                {
                    collection.InsertOne(new Book(vs[0], vs[1], cities.ToList()));
                   
                }
                else if(1 == vs.Length)
                {
                    collection.InsertOne(new Book(vs[0], "", cities.ToList()));

                }
                cities.Clear();
                Console.WriteLine(i++);

                    //       Console.ReadLine();
                
            }





            return books;
        }
    }
}
        