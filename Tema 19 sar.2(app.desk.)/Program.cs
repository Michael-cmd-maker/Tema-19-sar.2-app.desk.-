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

Console.Write("Alege operatia (+, -, *, /): ");
string? operatie = Console.ReadLine();

switch (operatie)
{
    case "+":
        Console.WriteLine($"Rezultat: {a + b}");
        break;

    case "-":
        Console.WriteLine($"Rezultat: {a - b}");
        break;