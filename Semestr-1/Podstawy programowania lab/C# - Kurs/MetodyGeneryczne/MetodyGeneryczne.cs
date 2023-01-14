//(C) Michal Turek
using System;
class Program
{
	static void metoda<Szablon1, Szablon2>( Szablon1 param1,  Szablon2 param2)
	{
		Console.WriteLine(param1.ToString());
		Console.WriteLine(param2.ToString());
	}
	static void Main(string[] args)
	{
		
		metoda<int, int>( 10, 10);
		metoda<string, string>( "10", "10");
		Console.ReadKey(true);

	}

}


