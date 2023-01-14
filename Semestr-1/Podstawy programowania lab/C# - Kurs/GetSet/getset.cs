// (C) Michal Turek
using System;
namespace przyklad
{
 	public class Cl3 {
  		private float  liczba ;		// pole  prywatne
  		public  int  dane {
 			set {   liczba = (float)value; }
     		get {   return (int)liczba ; }
 		}
	}

	public class Demo
  	{
    	public static void Main()
    	{
     	
    		Cl3 obiekt = new Cl3( );
			obiekt. dane = 100 ;            		// u¿ycie set
	      	Console.WriteLine("Dane:");
			Console.WriteLine( obiekt.dane ); 
      	  	Console.In.ReadLine();

    	}
  	}
  
}
