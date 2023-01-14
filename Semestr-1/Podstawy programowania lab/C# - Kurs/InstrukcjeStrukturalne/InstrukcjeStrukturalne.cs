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
			int a = 3;
			int b = 4;
			
			if (a == b)
			{
				Console.WriteLine("rowne");
			}
			else
			{
				if (a < b)
				{
					Console.WriteLine("wieksze");
				}
				else if (a > b)
				{
					Console.WriteLine("mniejsze");
				}
			}
			
			
			// operator ternary
			Console.WriteLine("wynik: " + ( a < b ? "mniejsze" : "wieksze lub rowne"));
			
			
			for(a = 0; a < 10; a++)
			{
				Console.WriteLine("a: " + a);
			}
			
			int[] tab = {1,2,3};
			foreach (int c in tab )
			{
				Console.WriteLine("c: " + c);
			}
			
			while (a < 20)
			{
				Console.WriteLine("a: " + a);
				a++;
			}

			
			do
			{
				Console.WriteLine("a: " + a);
				a++;

			} while (a < 30);
			
			
			switch(a)
			{
				case 2:
					// opcja
					Console.WriteLine("dwa");
					Console.WriteLine("dwa");
					break;
				case 4:
					// opcja
					Console.WriteLine("cztery");
					Console.WriteLine("cztery");
					break;
				default:
					// domyslna
					Console.WriteLine("nie cztery i nie dwa");
					Console.WriteLine("nie cztery i nie dwa");
					break;
			}
			
			Console.In.ReadLine();
		}
	}
}

