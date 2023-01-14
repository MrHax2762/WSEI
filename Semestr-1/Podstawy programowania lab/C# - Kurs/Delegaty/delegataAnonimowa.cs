// (C) Michal Turek
using System;
namespace przyklad
{
	public class Delegaty
	{

		public delegate void Delegata(int value);

		static void Main(string[] args)
		{
			Delegata metoda = delegate(int param) 
			{
				Console.WriteLine("Metoda: " + param);
			};

			metoda(10);
			Console.ReadKey(true);

		}
	}
}
