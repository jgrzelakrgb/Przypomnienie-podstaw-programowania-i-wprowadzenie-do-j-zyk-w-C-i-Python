using System;

class Program
{
static void Main()
{
Console.Write("Podaj pierwszą liczbę: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj drugą liczbę: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj działanie (+, -, *, /): ");
string znak = Console.ReadLine();

if (znak == "+")
{
Console.WriteLine("Wynik: " + (a + b));
}
else if (znak == "-")
{
 Console.WriteLine("Wynik: " + (a - b));
}
else if (znak == "*")
{
Console.WriteLine("Wynik: " + (a * b));
}
else if (znak == "/")
{
Console.WriteLine("Wynik: " + (a / b));
}
else
{
Console.WriteLine("Błędne działanie");
}
}
}
