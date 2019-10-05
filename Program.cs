using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public abstract class Tools
    {
        public static double Age(DateTime Birth)
        {
            return ((DateTime.Now - Birth).Days / 365.25);
        }
    }
    public class Person
    {
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public DateTime Birth { get; set; }
        public Person(string nom, string prenom, DateTime birth)
        {
            Nom = nom;
            Prénom = prenom;
            Birth = birth;
        }
    }
    public class Phoneux : Person
    {
        public string Numéro { get; set; }
        public Phoneux(string nom, string prenom, DateTime birth, string numero) : base(nom, prenom, birth)
        {
            Numéro = numero;
        }
    }

    public delegate void Del(string message);

    class Program
    {
        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }
        static void Main(string[] args)
        {

            #region Classe
            string Nom = Console.ReadLine();
            string Prénom = Console.ReadLine();
            DateTime Birth = Convert.ToDateTime(Console.ReadLine());

            Person p = new Person(Nom, Prénom, Birth);

            Phoneux Ph = new Phoneux(Nom, Prénom, Birth, "0618041027");

            Console.WriteLine($"Call {Ph.Prénom} at {Ph.Numéro}...");
            Console.WriteLine("Age = " + Tools.Age(Ph.Birth).ToString());
            Console.WriteLine($"Hello {p.Prénom} !!!");

            Console.ReadLine();
            #endregion Classe

            #region Tableau
            int[] tints = { 3, 2, 1 };
            foreach (var tint in tints)
            {
                Console.WriteLine(tint);
            }
            Console.ReadLine();
            Array.Sort(tints);
            foreach (var tint in tints)
            {
                Console.WriteLine(tint);
            }
            Console.ReadLine();
            #endregion Tableau

            #region Liste
            List<int> li = new List<int>();
            li.Add(3);
            li.Add(2);
            li.Add(1);
            li.Sort();
            foreach (var tint in li)
            {
                Console.WriteLine(tint);
            }
            Console.ReadLine();
            #endregion Liste

            #region Delegate
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
            Console.ReadLine();
            #endregion Delegate

        }
    }
}
