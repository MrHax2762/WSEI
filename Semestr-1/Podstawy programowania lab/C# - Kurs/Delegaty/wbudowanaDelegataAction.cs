// (C) Michal Turek
using System;
class Program
{
    static void metoda(int a)
    {
        Console.WriteLine("Action: " + a);
    }

    static void Main(string[] args)
    {
        Action<int> d1 = metoda;  // delegata action nie zwraca warto?ci (w przeciwie?stwie do Func)
        d1(10);
        Console.In.ReadLine();
        
    }
}

