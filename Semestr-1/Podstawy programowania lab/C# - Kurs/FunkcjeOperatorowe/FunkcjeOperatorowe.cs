// (C) Michal Turek
using System;
namespace p2
{
	public class P1
	{
		public int dane;
		public static P1 operator + (P1 o1, P1 o2)		{
			P1 p = new P1();
			p.dane = o1.dane + o2.dane;
			return p;
		}
		public static P1 operator + (P1 o1, int o2)		{
			P1 p = new P1();
			p.dane = o1.dane + o2;
			return p;
		}
		public static P1 operator ++ (P1 o1)		{
			o1.dane++;
			return o1;
		}
	} 
	class Program
	{
		public static void Main(string[] args)
		{
			P1 o1 = new P1(); o1.dane = 10;
			P1 o2 = new P1(); o2.dane = 15;
			P1 o3 = o1++ + o2 + 6;
			Console.WriteLine("Wynik " + o3.dane);
					
			Console.ReadKey(true);
			
		}
	}
	
}