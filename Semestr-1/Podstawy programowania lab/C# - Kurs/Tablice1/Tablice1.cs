// (C) Michal Turek
using System;
namespace przyklad
{
  public class Tablica
  {
    public static void Main()
    {
      String[] Meble = {
        "Szafa",
        "Krzeslo",
        "Fotel",
      };
      foreach (string mebel in Meble)
      {
        Console.WriteLine(mebel);
      }
      Console.In.ReadLine();
    }
  }
}