// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		List<int> lista = new List<int>();
		lista.Add(12);
		lista.Add(11);
		lista.Add(14);
		lista.Add(10);

		IEnumerator numery = lista.GetEnumerator();
		while (numery.MoveNext())
			Console.WriteLine("Wynik " + numery.Current);
		Console.In.Read();
	}
}

