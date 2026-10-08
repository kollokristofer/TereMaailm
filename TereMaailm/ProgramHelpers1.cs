using System;
// TereMaailm konsoolirakendus
internal static class ProgramHelpers1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mis su nimi on? ");
        string nimi = Console.ReadLine();
        Console.WriteLine($"Tere, {nimi}!");
    }
}