// (C) Michal Turek
using System;
namespace przyklad
{
  public class wyrazenia
  {
    public static void Main()
    {
      int a = 5;
      float b = (int)5;
      int liczba = a * (int)b;
      bool flaga = !(a == b);      
      String s = "test";
      Console.WriteLine(a is int);
      Console.WriteLine((s as object).ToString());
      Console.In.ReadLine();
    }
  }
}