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
			      		
			Console.ReadKey(true);
		}
	}
	
	public class Budynek
  {
    public string GetOpis() {
      return "Budynek";
    }
  }
  public class Biurowiec : Budynek
  {
    
  }
  public class Kamienica : Budynek
  {
    
  }
  public class DomJednorodzinny: Budynek
  {
   
  }
  public class BlokMieszkalny : Budynek
  {
    
  }

 
	
}