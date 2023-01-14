//(C) Michal Turek
using System;
using System.Collections.Generic;

namespace p1
{
	class Program
	{
				
		public static void Main(string[] args)
		{
			Budynek budynek1 = new Budynek();
			budynek1.SetWysokosc(3);
			Budynek budynek2 = new Budynek();
			budynek2.SetWysokosc(6);
			
			Biuro biuro1 = new Biuro();
			
			IBudynek ibudynek;
			//ibudynek = (Budynek)budynek2;
			ibudynek = (Biuro)biuro1;
			
						
			Console.WriteLine("Wysokosc " + ibudynek.GetWysokosc ());
						
			Console.ReadKey(true);
		}
	}
	
	public interface IBudynek
	{
			int GetWysokosc();
	}
	public class Budynek : IBudynek
   {
    private int wysokosc;
	public void SetWysokosc(int wysokosc) {
      this.wysokosc = wysokosc;
    }	
    
	public int GetWysokosc() {
      return this.wysokosc;
    }	
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
  public class Biuro : IBudynek
  {
    public string GetOpis() {
 		return "Biuro";    
  	}
  	public int GetWysokosc() {
      return 13;
    }	
  	
  }
   	
}

