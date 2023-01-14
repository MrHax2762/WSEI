//(C) Michal Turek
using System;
using System.Threading;

namespace p2
{
	public class Watek
	{
		public void metoda()
		{
			int p = 0;
			try {
				while (p < 10)
					
				{
					Thread.Sleep(500);
					p++;
					Console.WriteLine("licznik: " + p);
				}
			}
			catch (ThreadAbortException e)
			{
				Console.WriteLine("WYJATEK: ");
				Console.WriteLine(e.ToString());
			}
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			//Thread w1 = new Thread(new ThreadStart(Watek.metoda));
			Watek m1 = new Watek();
			Thread w1 = new Thread(new ThreadStart(m1.metoda));
			Thread w2 = new Thread(new ThreadStart(m1.metoda));
			
			w1.Start();
			w2.Start();
			Thread.Sleep(3000);
			
			w1.Abort();
			w2.Abort();
	
			
			Console.ReadKey(true);
		}
	}
}
