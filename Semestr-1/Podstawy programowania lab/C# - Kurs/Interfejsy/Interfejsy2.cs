// (C) Michal Turek
using System;
namespace przyklad
{
  public class Interfejsy
  {
    public static In1 i1;
  	public static void Main()
    {
  	  Cl5 c = new Cl5();
  	  Clobca obca = new Clobca();
  	  obca.i1 = (In1) c;
  	  obca.x();
  	  Console.In.ReadLine();
    }
  }
  public interface In1 {
    	void metoda( );
    } 
  public class Cl5 : In1 {
    	public void metoda()
    	{
    	  Console.WriteLine("metoda");
    	}
    }
  public class Clobca {
    	public In1 i1;
    	public void x() {
    		if (i1 != null) i1.metoda();
    	}
    }
}
  
