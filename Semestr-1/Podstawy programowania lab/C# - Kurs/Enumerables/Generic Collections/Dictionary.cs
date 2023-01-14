// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Dictionary<int, string> katalog1 = new Dictionary<int, string>(); // key value
		katalog1.Add(12, "aa");
		katalog1.Add(11, "bb") ;
		katalog1.Add(14, "ee");
		katalog1.Add(10, "dd");
		foreach(KeyValuePair<int, string> para in katalog1)
    		Console.WriteLine("Key: " + para.Key +", Value: " + para.Value);
		
		// inicjalizator
		Dictionary<int, string> katalog2 = new Dictionary<int, string>()
			{{ 1, "x"},{ 2, "y"},{ 3, "z"}};
		
		Console.WriteLine(katalog1[12]); // vlaue dla key=12
		if(katalog1.ContainsKey(11))
			Console.WriteLine("Yes");
		
		string value1;
		if(katalog1.TryGetValue(14, out value1)) // próba pobrania value jeœli key istnieje
    		Console.WriteLine(value1);
		katalog1.Clear();

	
		
		Console.In.Read();
	}
}

