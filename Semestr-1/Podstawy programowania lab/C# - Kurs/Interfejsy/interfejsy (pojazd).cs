// (C) Michal Turek
using System;
namespace przyklad
{
  public class Interfejsy
  {
  	public static void Main()
    {
  		Sterownik ster = new Sterownik();
  		PojazdMechaniczny p = new PojazdMechaniczny();
	  	ster.st = (Sterowanie) p;
  	  	ster.steruj();
  	  	Console.In.ReadLine();
    }
  }
  public interface Sterowanie {
    	 void Ruszaj ( );
    	 void Stop ( );
  } 
  public class PojazdMechaniczny : Sterowanie {
  	public void Ruszaj () {Console.WriteLine("ruszam");}
  	public void Stop () {}
  }
  public class Sterownik 
  {
  	public Sterowanie st;
  	public void steruj ()
  	{
  		if (st != null)
  			st.Ruszaj();
  	}
  }
}
