// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Numerowana num = new Numerowana();
		num.Reset();
		Console.WriteLine(num.Current);
		num.MoveNext();
		Console.WriteLine(num.Current);
		num.Current = 4;
		Console.WriteLine(num.Current);
		Console.In.Read();
	}
}

public class Numerowana : IEnumerator
{
	int index = 0;
	int [] dane = new int[3]{1,2,3};
	
	public object Current
	{
		get { return (object) dane[index];}
		set { dane[index] = (int)value;}
	}

	public bool MoveNext()
	{
		if (index < dane.Length) {
			index++;
			return true;
		} else return false;
	}

	public void Reset()
	{
		index = 0;
	}
}
