using edu.stanford.nlp.ie.crf;
using GutenBergProjectApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace GutenbergReader
{
    class Program
    {
        static void Main(string[] args)
        {

            FileReader fileReader = new FileReader();
            //fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles");

            Task task1 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread1"));
            Task task2 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread2"));
          Task task3 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread3"));
            /*    Task task4 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread4"));
            Task task5 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread5"));
             Task task6 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread6"));
             Task task7 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread7"));
             Task task8 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread8"));
           Task task9 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread9"));
                Task task10 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread10"));
               Task task11 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread12"));
               Task task12 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread13"));
               Task task13 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread14"));
               Task task14 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread15"));
               Task task15 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread16"));
               Task task16 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread17"));
               Task task17 = Task.Run(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\thread18"));
             Task task18 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task19 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task20 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task21 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task22 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task23 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task24 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task25 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task26 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));

                Task task27 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task28 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task29 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task30 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task31 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task32 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task33 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task34 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task35 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task36 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task37 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task38 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task39 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task40 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task41 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task42 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task43 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task44 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task45 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task46 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task47 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task48 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task49 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task50 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task51 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task52 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));

                Task task53 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task54 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task55 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task56 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task67 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task68 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task69 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task70= Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task71 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task78 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task79 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task80 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task81 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task82 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task83 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task84 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task85 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task86 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task87 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task89 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task90 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task91 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task92 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task93 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task94 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
                Task task95 = Task.Factory.StartNew(() => fileReader.getStreamFromTxtFile("C:\\Users\\Mohammad Saad\\Desktop\\try\\root\\zipfiles"));
    */

            Task.WaitAll(task1, task2, task3);
        }
    }
}

