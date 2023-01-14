//(C) Michal Turek
using System;
using System.Threading;

namespace p2
{
	public class Watek
	{
		public static void metoda()
        {
			int p = 0;
			while (true)
            {
                Thread.Sleep(500);
                p++;
				Console.WriteLine("licznik: " + p);
			}
		}
	}
		
	class Program
	{
		public static void Main(string[] args)
		{
			Thread w1 = new Thread(new ThreadStart(Watek.metoda));
            w1.Start();
  			Thread.Sleep(3000);
  			
  			new Thread(new ThreadStart(Watek.metoda)).Start();
                      
			Console.ReadKey(true);
		}
	}
}
