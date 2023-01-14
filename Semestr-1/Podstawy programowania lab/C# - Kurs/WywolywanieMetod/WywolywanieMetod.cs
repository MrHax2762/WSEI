//(C) Michal Turek
using System;
using System.Collections.Generic;

namespace p1
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			string text = "pierwotny";
			Cl1.metoda ( out text );
			Console.WriteLine("Wynik: " + text);
			
			Cl1 c = new Cl1();
			c.text = "pierwotny";
			Cl1.metoda ( ref c );
			Console.WriteLine("Wynik: " + c.text);
			
			Cl1.metoda(1);  // params
			Cl1.metoda(1,2);
			Cl1.metoda(1,2,4);
			
			Console.ReadKey(true);
		}
	}
	public class Cl1
	{
		public string text;
		public static void metoda (out string parametr) {
			parametr = "zmieniony";
		}

		public static void metoda (ref Cl1 parametr) {
			parametr.text = "zmieniony";
		}

		public static void metoda ( params int[ ] parametry ) {
			if (parametry.Length > 0)
				Console.WriteLine("Wynik dla ostatniego : " + parametry[parametry.Length - 1 ]);
		}
	}
}
