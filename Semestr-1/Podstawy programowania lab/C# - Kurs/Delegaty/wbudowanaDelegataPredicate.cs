// (C) Michal Turek
using System;
class Program
{
    static bool metoda(int a)
    {
        return (a == 2);
    }

    static void Main(string[] args)
    {
        Predicate<int> d1 = metoda; // tylko jeten parametr, nie deklarujemy warto?ci zwracanej
        Console.WriteLine("Wynik " + d1(10));
        Console.In.ReadLine();
        
    }
}

