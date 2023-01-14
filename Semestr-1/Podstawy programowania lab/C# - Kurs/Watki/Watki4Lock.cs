//(C) Michal Turek
using System;
using System.Threading;

namespace p2
{
	public class Watek
	{
		static readonly object obj = new object();
		public static void metoda()
		{
			int p = 0;
			lock (obj)
			{
				while (p < 5)
				{
					Thread.Sleep(500);
					p++;
					Console.WriteLine("licznik: " + p);
				}
			}
			
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Thread w1 = new Thread(new ThreadStart(Watek.metoda));
			Thread w2 = new Thread(new ThreadStart(Watek.metoda));
			w1.Start();
			w2.Start();
			Console.ReadKey(true);
		}
	}
}

