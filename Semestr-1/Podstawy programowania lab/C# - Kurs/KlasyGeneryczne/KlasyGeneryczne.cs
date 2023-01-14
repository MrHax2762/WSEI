//(C) Michal Turek
using System;
namespace przyklad
{
 	
	public class Operacje<Szablon>
	{
		Szablon   dane;
		public void Wpisz(Szablon item) {dane = item;}
		public Szablon Pobierz() { return dane;}
	}

	public class Glowna
  	{
    	public static void Main()
    	{
    		Operacje <int>    obiekt  = new Operacje <int>();
    		obiekt.Wpisz(14);
    		int x = obiekt.Pobierz();
	
			Console.WriteLine("Wynik" + x ); 
      	  	Console.In.ReadLine();
    	}
  	}
}
