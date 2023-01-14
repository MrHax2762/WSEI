// (C) Michal Turek
using System;

class Cl1 {
	public static void Main()
	{
		Cl2 c = new Cl2();
		c.metoda1();
		c.metoda2();
		Console.In.Read();
	}
}

public partial class Cl2
{ // Pierwszy blok
	private int dane1;
	public void metoda1() {}
}
partial class Cl2
{ // Drugi blok
	private int dane2;
	public void metoda2() {}
}

