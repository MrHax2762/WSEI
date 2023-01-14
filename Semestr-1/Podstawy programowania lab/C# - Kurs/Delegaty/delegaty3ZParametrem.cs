// (C) Michal Turek
using System;
namespace przyklad
{
	public class Delegaty
	{
		public delegate void MojDelegat(string tekst);
		public static void Main()
		{
			MojDelegat d1 = new MojDelegat(Cl1.Metoda1);
			MojDelegat d2 = new MojDelegat(Cl1.Metoda2);
			d1("test");
			d2("test");
			d1.Invoke("test");
			metoda (d1);
			Console.In.ReadLine();
		}
		static void metoda(MojDelegat dele)
		{
			dele("z parametrem");
		}
	}
	public class Cl1
	{
		public static void Metoda1(String tekst)
		{
			Console.WriteLine("Metoda1: " + tekst);
		}
		public static void Metoda2(String tekst)
		{
			Console.WriteLine("Metoda2: " + tekst);
		}

	}
}
