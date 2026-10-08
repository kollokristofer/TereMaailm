using System;

namespace TereMaailm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mis su nimi on? ");
            string nimi = Console.ReadLine();
            Console.WriteLine($"Tere, {nimi}!");
        }
    }
}