// (C) Michal Turek
using System;
namespace przyklad
{
  public class TypEnum
  {
    enum Budynki // z wartoœciami nadanymi
    {
      Kamienica = 0,
      Blok = 1,
      Dom_Jednorodzinny = 2,
    }
    
    enum Budynki2  // z wartosciami automatycznymi i nieregularnym (przeduniêcie inkrementacji)
    {
      Kamienica,        // =0 (wartosc poczatkowa(
      Blok,			    // =2
      Dom_Jednorodzinny = 8,
      Dom_Blizniak		// =9
      
    }
    
    enum Budynki3 : long // z wymuszeniem typu
    {
      Kamienica,        
      Blok,		    
      Dom_Jednorodzinny,
      
    }

    
    public static void Main()
    {
      Budynki budynek = new Budynki();
	budynek = Budynki.Blok;
      budynek = budynek + 1;
      Console.WriteLine(budynek);
      Console.WriteLine((int) budynek);  // enum to int
      Console.In.ReadLine();
    }
    
    
  }  
}


