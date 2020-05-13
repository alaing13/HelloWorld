using System;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tints = { 3, 2, 1 };
            foreach (var tint in tints)
            {
                Console.WriteLine(tint);
            }
            Console.WriteLine();
            Array.Sort(tints);
            foreach (var tint in tints)
            {
                Console.WriteLine(tint);
            }
            Console.ReadLine();
        }
    }
}