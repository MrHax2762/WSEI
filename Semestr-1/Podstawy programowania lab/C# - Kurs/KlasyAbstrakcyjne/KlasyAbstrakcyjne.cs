// (C) Michal Turek
using System;
namespace przyklad
{
  public class Abstrakcyjne
  {
    public static void Main()
    {
      SamochodCiezarowy p1 = new SamochodCiezarowy();
      Console.In.ReadLine();
    }
  }
  
  public abstract class Pojazd {
  	public abstract void Ruszaj( ) ;
  	public abstract void Stop( ) ;
  }
  
  public class SamochodCiezarowy: Pojazd {
  	public override void Ruszaj( ) {}
  	public override void Stop( ) {}
  }
  
  
  
}
  

