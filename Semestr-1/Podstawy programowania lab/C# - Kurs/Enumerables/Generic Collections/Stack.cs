// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Queue<int> kolejka = new Queue<int>();
		kolejka.Enqueue(10);
		kolejka.Enqueue(12);
		kolejka.Enqueue(11); 
		int a = kolejka.Dequeue();

		// inicjalizator
		int[] tablica1 = new int[]{ 1, 2, 3};
		Queue<int> kolejka2 = new Queue<int>(tablica1);

		// dostêp, pomimo struktury kolejka
		foreach (var item in kolejka2)
     		Console.Write(item + ", ");
     	
		Console.In.Read();
	}
}

