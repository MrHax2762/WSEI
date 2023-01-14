//(C) Michal Turek
using System.Collections.Generic;

public class Program
{
	static void Main(string[] args)
	{
		IList<Cl1> lista = new List<Cl1>() { 
                    new Cl1() { dane1 = 1, dane2 = "tekst"} ,
                    new Cl1() { dane1 = 1, dane2 = "tekst"} };
               }
}

public class Cl1
{
	public int dane1 { get; set; }
	public string dane2 { get; set; }
}
