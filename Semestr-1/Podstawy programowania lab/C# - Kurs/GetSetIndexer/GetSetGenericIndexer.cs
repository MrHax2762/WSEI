// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Indeksowana<string> ind = new Indeksowana<string>();
		ind[3] = "xx";
		Console.WriteLine(ind[3]);
		Console.In.Read();
	}
}

class Indeksowana <Szablon>
{
	private Szablon[] dane = new Szablon[10]; // dane

	public Szablon this[int id]
	{
		get
		{
			if (id >= 0 && id < dane.Length)
				return dane[id];
			else return default(Szablon); // warto?? domyslna dla typu Szablon czymkolwiek b?dzie
		}
		set
		{
			if (id >= 0 && id < dane.Length)
				dane[id] = value;
		}

	}
}
