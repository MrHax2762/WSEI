//(C) Michal Turek
using System;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		metoda();
		metoda2();		
		Console.ReadKey();
	}
	public static async void metoda()
	{
		Console.WriteLine("metoda");
		await Task.Delay(2000); // zatrzymaj na 2 sekundy
		Console.WriteLine("metoda");
		await Task.Delay(2000); 
		Console.WriteLine("metoda");
		
	}
	static void metoda2()
	{
		Console.WriteLine("metoda2");
		Console.WriteLine("metoda2");
	}
}