using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbe ocen: ");
        int liczba = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= liczba; i++)
        {
            Console.Write("Podaj ocene: ");
            double ocena = double.Parse(Console.ReadLine());

            suma = suma + ocena;
        }

        double srednia = suma / liczba;

        Console.WriteLine("Srednia = " + srednia);

        if (srednia >= 3)
        {
            Console.WriteLine("Uczen zdal");
        }
        else
        {
            Console.WriteLine("Uczen nie zdal");
        }

        Console.ReadKey();
    }
}
