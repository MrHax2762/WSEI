// (C) Michal Turek
using System;
namespace przyklad
{
    /// <summary>
    /// Klasa pokazuje jak dokumentowac
    /// </summary>
    public class Dokumentowanie
    {
        /// <summary>
   		/// m_iZmienna jest atrybutem tej klasy
    	/// </summary>
        private int m_iZmienna = 10;
	    /// <summary>
   		/// Metoda Main
    	/// </summary>
        public static void Main()
        {
	        Console.WriteLine("Tekst w C#");
		Console.In.ReadLine();
        }
        /// <summary>
    	/// <param name="liczba"> Pierwszy i jedyny parametr metody</param>
   		/// <returns> Metoda zwraca liczba powiekszone o 1</returns>
   		/// <see>metoda2</see>
   		/// </summary>
        public int metoda1 (int liczba)
        {
       		return liczba+1;
	    }
	    /// <summary>
    	/// <param name="liczba"> Pierwszy i jedyny parametr metody</param>
   		/// <returns> Metoda zwraca liczba pomniejszone o 1</returns>
   		/// <see>metoda1</see>
   		/// </summary>
        public int metoda2 (int liczba)
        {
       		return liczba-1;
	    }
        
    }
}