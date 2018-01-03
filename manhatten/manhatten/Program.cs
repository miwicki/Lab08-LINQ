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

            //Deserializing Json in this file
            var data = Hood.FromJson(jsonStuffs);

            //Returning all data, unfiltered, in json string format
            IEnumerable<Feature> rawdata = from x in data.Features
                                           where x.Properties.Neighborhood != null
                                           select x;
            foreach (var x in rawdata)
            {
                Console.WriteLine(o.Properties.Neighborhood);
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }


    }
}
