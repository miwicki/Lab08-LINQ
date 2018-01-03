using System;
using System.IO;
using QuickType;
using System.Collections.Generic;
using System.Linq;

namespace manhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the path
            string fileName = "data.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"manhatten\", fileName);
            string jsonStuffs;


            //using streamreader to read json file
            using (StreamReader sr = File.OpenText(path))
            {
                jsonStuffs = File.ReadAllText(path);
                Console.WriteLine(jsonStuffs);
                Console.ReadLine();
                Console.Clear();
            }


        }


    }
}
