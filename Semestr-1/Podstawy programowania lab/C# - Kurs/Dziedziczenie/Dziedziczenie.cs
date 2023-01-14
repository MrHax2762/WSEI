// (C) Michal Turek
using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
        	NowaKlasa nowaInstancja;
        	nowaInstancja = new NowaKlasa();
        	nowaInstancja.a = 13;
        	nowaInstancja.metoda(12);
        	nowaInstancja.znadklasy = 6;
        }
    }
    class NadKlasa
    {
    	public int znadklasy = 10;
    }   
    class NowaKlasa : NadKlasa
    {
		public int a = 0;
		public void metoda (int a)
		{
			Console.Write("to jest tekst z metody klasy: " + this.a + ",  " + znadklasy);
			Console.In.ReadLine();
		}
    }
}

