// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
class Cl1 {
	
	public static void Main()
	{
		List<int> lista = new List<int>();
		lista.Add(12);
		lista.Add(11);
		lista.Add(14);
		lista.Add(10);
		int [] dane = new int[3]{1,2,3};
		lista.AddRange(dane);
		lista.Remove(dane[1]);
		lista.RemoveAt(1);
		lista.Insert(1, 15);  // na pozycji 1
		if (lista.Contains(15)) Console.WriteLine("Yes");
		
		Console.WriteLine("String[0] : " + lista[0]);
		Console.WriteLine("String-Array[0] : " + lista.ToArray()[0]);
		Console.WriteLine("String-Array[0] : " + lista.ToArray()[0].ToString());
		Console.WriteLine("int[3] : " + lista.ToArray()[3]);
		Console.WriteLine("string representation[3] : " + lista.ToArray()[3].ToString());
		foreach(var l in lista)
			Console.Write(l + " ");
		Console.WriteLine();
		
		// inicjalizator:
		var lista2 = new List<int>() {12,11,14,10};
		var lista3 = new List<Cl2>() {new Cl2(){ a = 1, b="x"},new Cl2(){ a = 2, b="y"},new Cl2(){ a = 3, b="z"}};
		var selected = from cl1 in lista3
			where cl1.a == 1
			select cl1.b;
		foreach(var a in selected)
			Console.Write(a + " ");
		Console.WriteLine();
		
		Console.In.Read();
	}
}
public class Cl2
{
	public int a;
	public string b;
}

