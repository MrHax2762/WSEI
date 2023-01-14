//(C) Michal Turek
using System;

namespace p1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Budynek budynek = new Budynek();
			
			Console.WriteLine(budynek.GetOpis());
			
			Console.ReadKey(true);
		}
	}
	
	public class Budynek
	{
		public string GetOpis() 
		{
			return "Budynek";
		}
	}
	
}