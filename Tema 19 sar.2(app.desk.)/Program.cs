using System;

Console.WriteLine("=== Calculator-CS ===");

Console.Write("Introdu primul numar: ");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("Primul numar este invalid.");
    return;
}

Console.Write("Introdu al doilea numar: ");
if (!double.TryParse(Console.ReadLine(), out double b))
{
    Console.WriteLine("Al doilea numar este invalid.");
    return;
}