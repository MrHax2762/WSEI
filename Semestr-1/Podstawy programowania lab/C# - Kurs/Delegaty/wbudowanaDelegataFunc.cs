// (C) Michal Turek
using System;
class Program
{
    static int metoda(int a)
    {
        return a + 2;
    }

    static void Main(string[] args)
    {
        Func<int, int> d1 = metoda; // ostatni parametr traktowany jest jako wyjœciowy
        Console.WriteLine("Wynik " + d1(10));
        Console.In.ReadLine();
        
    }
}

