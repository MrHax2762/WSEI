// (C) Michal Turek
using System;
namespace przyklad
{
	public class Zmienne
	{
		public static void Main()
		{
			Cl1 c = new Cl1();
			Cl1.textStatic = "zmieniny gdziekolwiek z odwolania do klasy";
			Console.WriteLine("Read only: " + c.textReadOnly);
			Console.WriteLine("Static: " + Cl1.textStatic);
			Console.WriteLine("Const: " + Cl1.textConst);  // do konst odwolanie tak¿e porzez nazwe Klasy
			c.text = "zmieniony gdziekolwiek";
			Console.WriteLine("Zwykly: " + c.text);
			Console.In.ReadLine();
		}
	}
	public class Cl1
	{
		public String text;
		public static String textStatic;
		public const String textConst = "staly tekst";
		public readonly String textReadOnly = "pierwotny tekst";
		
		public Cl1()
		{
			this.textReadOnly = " zmieniony w konstuktorze";
		}
		
	}
}