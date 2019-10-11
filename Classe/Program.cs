using System;

namespace Classe
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
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Entrez votre nom :");
            string Nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom :");
            string Prénom = Console.ReadLine();
            DateTime Birth = GetBirth();

            Person p = new Person(Nom, Prénom, Birth);

            Phoneux Ph = new Phoneux(Nom, Prénom, Birth, "0618041027");

            Console.WriteLine($"Call {Ph.Prénom} at {Ph.Numéro}...");
            Console.WriteLine($"Age = {Tools.Age(Ph.Birth)} ans...");
            Console.WriteLine($"Hello {p.Prénom} !!!");

            Console.ReadLine();

        }
        private static DateTime GetBirth()
        {
            Console.WriteLine("Entrez votre date de naissance :");
            DateTime Birth = Convert.ToDateTime(Console.ReadLine());
            return Birth;
        }
    }
}