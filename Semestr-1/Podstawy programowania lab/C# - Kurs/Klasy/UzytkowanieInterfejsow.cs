//(C) Michal Turek
using System;
using System.Collections.Generic;

namespace p1
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Budynek budynek = new Budynek();
			
			IBudynek ibudynek;
			ibudynek = (Budynek)budynek;
			ibudynek.GetWysokosc ();
			
			Console.WriteLine("Wysokosc " + budynek.GetWysokosc());
			Console.ReadKey(true);
		}
	}
	
	public interface IBudynek
	{
		int GetWysokosc();
	}
	public class Budynek : IBudynek
	{
		
		public int GetWysokosc() {
			return 10;
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
	public class Biuro
	{
		public string GetOpis() {
			return "Biuro";
		}
	}
	
}
