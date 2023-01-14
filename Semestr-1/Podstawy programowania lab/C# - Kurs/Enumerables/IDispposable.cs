// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Cl1 {
	
	public static void Main()
	{
		Porownywalna num = new Porownywalna();
		Console.In.Read();
	}
}

public class Porownywalna : IDisposable
{
	int index = 10;
	public void Dispose() {
		Console.WriteLine("Disposed");
	}
}

