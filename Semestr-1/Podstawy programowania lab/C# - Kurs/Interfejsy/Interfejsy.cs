// (C) Michal Turek
using System;
namespace przyklad
{
  public class Interfejsy
  {
  	public static void Main()
    {
  	  Cl6 c = new Cl6();
  	  Console.In.ReadLine();
    }
  }
  public interface In1 {
    	void metoda( );
  } 
  public abstract class Cl5 {
    	public abstract void metoda2( );
  }
  public class Cl6 : Cl5 , In1 {
    	public override void metoda2( )
    	{
    	}
        public void metoda( )
    	{
    	}	
  } 

}
  
