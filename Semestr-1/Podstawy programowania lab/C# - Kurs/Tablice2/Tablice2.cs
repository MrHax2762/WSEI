// (C) Michal Turek
using System;
class Tablice
{
    public static void Main()
    {
        int[] liczby = new int[7];  // jeden wymiar

	int [,,] liczby2 = new int [10,10,10]; 
        
        string[,] names = new string[7,7];  // dwa wymiary

        byte[][] dane = new byte[5][];  // tablica tablic
        for (int i = 0; i < dane.Length; i++)
        {
            dane[i] = new byte[i+3];
        }
        for (int i = 0; i < dane.Length; i++)
        {
            Console.WriteLine("Wielkosc wiersza {0} to {1}", i, dane[i].Length);
        }
        Console.In.ReadLine();
    }
}


