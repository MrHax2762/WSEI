//(C) Michal Turek
using System;
using System.Collections.Generic;

namespace p1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Biurowiec biurowiec = new Biurowiec();
			Biuro biuro = new Biuro();
			biurowiec.biura.Add(biuro);
			biurowiec.biura.Add(biuro);
			foreach (var b in biurowiec.biura)
				Console.WriteLine(b.GetOpis());									
			Console.WriteLine(biurowiec.GetOpis());
      		
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
    public List<Biuro> biura = new List<Biuro>();
    
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
  public class Biuro
  {
    public string GetOpis() {
 		return "Biuro";    
  	}
  }
   	
}
