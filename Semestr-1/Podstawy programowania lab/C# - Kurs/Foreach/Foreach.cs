// (C) Michal Turek
using System;
using System.Security.Cryptography;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
         	char[] tablica = {'A','B','C','D','E','F','G'};
 
         	for (int a = 0; a<tablica.Length ; a++) 
         		Console.Write(tablica[a]);
            
         	Console.WriteLine();
         		
         	foreach(char znak in tablica)
            {
                Console.Write(znak);
            }
        	Console.In.ReadLine();
        }
    }
}
