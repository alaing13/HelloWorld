using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Méthode ancienne
            //List<int> li = new List<int>();
            //li.Add(3);
            //li.Add(2);
            //li.Add(1);
            // Méthode nouvelle
            List<int> li = new List<int>
            {
                3,
                2,
                1
            };
            li.Sort();
            foreach (var tint in li)
            {
                Console.WriteLine(tint);
            }
            Console.ReadLine();
        }
    }
}