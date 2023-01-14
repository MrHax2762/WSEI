// (C) Michal Turek
using System;
namespace przyklad
{
  public class Delegaty
  {
    public delegate void MojDelegat<Szablon>(Szablon tekst);
    public static void Main()
    {
      MojDelegat<String> d1 = new MojDelegat<String>(Metoda1);
      d1("test");
      Console.In.ReadLine();
    }
    public static void Metoda1(String tekst)
    {
      Console.WriteLine("Metoda1: " + tekst);
    }
  
  }
}