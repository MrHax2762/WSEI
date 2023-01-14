using System;
using System.Collections.Generic;
using System.Text;

namespace Cl1
{
	class Program
	{
		
		public delegate int Delegata(Cl1 c);

		static void Main(string[] args)
		{
			Delegata metoda = delegate(Cl1 param)
			{
				return param.a;
			};
			Cl1 c = new Cl1();
			c.a = 10;
			metoda(c);
			
			Console.WriteLine("Delegata anonimowa inline: " + delegate (Cl1 c) {return c.a;}
			                  
			                  
			                  Console.ReadKey();
			}
	}
	public class Cl1
	{
		public int a = 10;
	}
}


