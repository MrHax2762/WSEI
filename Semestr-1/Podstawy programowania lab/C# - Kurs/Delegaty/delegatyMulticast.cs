// (C) Michal Turek
using System;
public delegate void Delegata(string text);

class delegowanie
{
	static void Main(string[] args)
	{
		Delegata d1 = Cl1.metoda1;
		Delegata d2 = Cl1.metoda2;
		Delegata d3 = Cl1.metoda3;
		Delegata dele = d1 + d2;
		dele("dodalismy 1 i 2");
		dele += d3;
		dele("dodalismy 3");
		dele -= d2;
		dele("usunelismy 2");
		Console.In.ReadLine();
	}
}
public class Cl1
{
	public static void metoda1(string text)
	{
		Console.WriteLine("Metoda1 " + text);
	}
	public static void metoda2(string text)
	{
		Console.WriteLine("Metoda2 " + text);
	}
	public static void metoda2(string text)
	{
		Console.WriteLine("Metoda3 " + text);
	}

}



