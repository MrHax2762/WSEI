// (C) Michal Turek
using System;
namespace przyklad
{
  public class Delegaty
  {
    public delegate void MojDelegat(string tekst);
    public static void Main()
    {
      MojDelegat d1 = new MojDelegat(Metoda1);
      MojDelegat d2 = new MojDelegat(Metoda2);
      d1("test");
      d2("test");
      Console.In.ReadLine();
    }
    public static void Metoda1(String tekst)
    {
      Console.WriteLine("Metoda1: " + tekst);
    }
    public static void Metoda2(String tekst)
    {
      Console.WriteLine("Metoda2: " + tekst);
    }
  }
}
