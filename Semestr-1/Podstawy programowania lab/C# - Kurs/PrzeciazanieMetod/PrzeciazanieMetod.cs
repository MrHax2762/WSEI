//(C) Michal Turek
using System;

namespace p1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Budynek budynek = new Budynek();
			Biurowiec biurowiec = new Biurowiec();
			
			Console.WriteLine(budynek.GetOpis());
			Console.WriteLine(biurowiec.GetOpis());
      		
			Object niewiadomoco = biurowiec;
      		if (niewiadomoco is Budynek)
      		{
      			Console.WriteLine(((Budynek)niewiadomoco).GetOpis());
				
      		}
			Console.ReadKey(true);
		}
	}
	
	public class Budynek
  {
    public virtual string GetOpis() {
      return "Budynek";
    }
  }
  public class Biurowiec : Budynek
  {
    public override string GetOpis() {
 		return "Biurowiec";    
  	}
  }
  public class Kamienica : Budynek
  {
    public override string GetOpis() {
 		return "Kamienica";    
  	}
  }
  public class DomJednorodzinny: Budynek
  {
    public override string GetOpis() {
 		return "DomJednorodzinny";    
  	}
  }
  public class BlokMieszkalny : Budynek
  {
    public override string GetOpis() {
 		return "BlokMieszkalny";    
  	}
  }

   
   
	
}
