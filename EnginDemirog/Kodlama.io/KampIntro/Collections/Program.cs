using System;
using System.Collections.Generic;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {

            };

            List<string> names2 = new List<string>{"Alptekin","Serbil","Fırat"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Murat");
            Console.WriteLine(names2[3]);
        }
    }
}