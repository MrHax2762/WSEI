// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Stack<int> stos = new Stack<int>();
		stos.Push(10);
		stos.Push(12);
		stos.Push(11); 
		int a = stos.Pop();

		// inicjalizator
		int[] tablica1 = new int[]{ 1, 2, 3};
		Stack<int> stos2 = new Stack<int>(tablica1);

		// dostêp, pomimo struktury stosu
		foreach (var item in stos2)
     		Console.Write(item + ", "); //prints 4,3,2,1,
     	
		Console.In.Read();
	}
}

