//(C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		int a = 10;
		if (a.JestWieksze(5))
			Console.WriteLine("Wieksze");
		a.WypiszI();
		Console.In.Read();
	}
}
public static class RozszerzenieInt
{
	public static bool JestWieksze(this int i, int value)  // this reprezentuje parametr charakterystyczny dla typu do kórego metoda jest do³¹czona (extension)
        {
            return i > value;
        }
	public static bool JestMniejsze(this int i, int value)
        {
            return i < value;
        }
	public static void WypiszI(this int i)
        {
		Console.WriteLine( i );
        }
}


