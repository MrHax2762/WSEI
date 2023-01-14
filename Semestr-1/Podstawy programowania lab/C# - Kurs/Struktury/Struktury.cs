// (C) Michal Turek
using System;
namespace przyklad
{
  public class Struktury
  {
    public static void Main()
    {
      Osoba o = new Osoba("Jan","Kowalski");
      Osoba o2 = o;		// kopia !
      o2.imie = "Inny";
      o2.nazwisko = "Kowalski ?";
      Console.WriteLine(o.imie+", "+o.nazwisko);
      Console.WriteLine(o2.imie+", "+o2.nazwisko);
      Console.In.ReadLine();
    }
  }
  public struct Osoba
  {
    public string imie, nazwisko;
    public Osoba(string imie, string nazwisko)
    {
      this.imie = imie;
      this.nazwisko = nazwisko;
    }
  }
}