// (C) Michal Turek
using System;
namespace przyklad
{
  public class Wyjatki
  {
    public static void Main()
    {
      try
      {
      int a = 5;
      int b = 5;
      int c = a/(a-b);
      }
      catch (Exception e)
      {
      Console.WriteLine("Zlapano wyjatek");
      Console.WriteLine(e.Message);
      }
      Console.In.ReadLine();

    }
  }
}