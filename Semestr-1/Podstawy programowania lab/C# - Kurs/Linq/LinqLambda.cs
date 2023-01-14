using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinQ
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int> la1 = x => x + x; // lambda
			Console.WriteLine("Dodawanie: " + la1(10));
			
			Console.ReadKey();
			}
	}
			
}
