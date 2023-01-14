//(C) Michal Turek
using System;
namespace przyklad
{
	// klasa generyczna wymagaj¹ca, aby Szablon by³ instancj¹ klasy implementujacej interfejs I1 . warunek mo¿e te¿ dotyczyæ instancji (nad)klasy, nie interfejsu
	
	public class Operacje<Szablon, Szablon2> where Szablon : I1
	{
		Szablon dane;
		public void Wpisz(Szablon item, Szablon2 item2) {
			item.m1();   // wywolanie metody zgodnie z interfejsem
			dane = item;
		}
		public Szablon Pobierz() { 
			 return dane;}
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
	
	public interface I1 {
		void m1();
	}
	public class C : I1
	{		public void m1(){}
	}
	public class D : C
	{		
	}
	
}

