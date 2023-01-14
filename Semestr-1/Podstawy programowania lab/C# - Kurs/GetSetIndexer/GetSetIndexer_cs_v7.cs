// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Indeksowana ind = new Indeksowana();
		ind[3] = "xx";
		Console.WriteLine(ind[3]);
		Console.In.Read();
	}
}

class Indeksowana
{
    private string[] dane = new string[10]; // dane

    public string this[int id]
    {
        get => data[id];

        set => data[id] = value;
    }
}
