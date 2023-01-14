//(C) Michal Turek
using System;
namespace przyklad
{
	public class Operacje<Szablon, Szablon2>
	{
		Szablon dane;
		public void Wpisz(Szablon item, Szablon2 item2) {dane = item;}
		public Szablon Pobierz() { return dane;}
	}
	public class Glowna
  	{
    	public static void Main()
    	{
    		Operacje <C, int> obiekt  = new Operacje <C, int>();
    		obiekt.Wpisz(new C(), 14);
    		C x = obiekt.Pobierz();
			Console.WriteLine("Wynik" ); 
      	  	Console.In.ReadLine();
    	}
  	}
	public class C {}
}
