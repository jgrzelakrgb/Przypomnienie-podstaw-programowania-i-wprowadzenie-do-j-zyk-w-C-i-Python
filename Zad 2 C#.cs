using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Konwerter temperatur");

        Console.Write("Wybierz C lub F: ");
        string wybor = Console.ReadLine();

        if (wybor == "C")
        {
            Console.Write("Podaj temperature w Celsjuszach: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = c * 1.8 + 32;

            Console.WriteLine("Temperatura w Fahrenheitach = " + f);
        }
        else if (wybor == "F")
        {
            Console.Write("Podaj temperature w Fahrenheitach: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = (f - 32) / 1.8;

            Console.WriteLine("Temperatura w Celsjuszach = " + c);
        }
        else
        {
            Console.WriteLine("Bledny wybor");
        }
    }
}