// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Porownywalna num = new Porownywalna();
		num.CompareTo(2);
		Console.WriteLine(num.CompareTo(10));
		Console.In.Read();
	}
}

public class Porownywalna : IComparable
{
	int index = 10;
	public int CompareTo(object obj) {
		if (obj == null) return 0;
		if (obj is int && obj.Equals(index)) return 1;
		return 0;
	}
}
