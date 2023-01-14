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
        TestSprawnosci test = new TestSprawnosci(62);
      }
      catch (AwariaException e)
      {
        Console.WriteLine("Wyjatek: ");
        Console.WriteLine(e.Message);
      }
      Console.In.ReadLine();
    }
  }
  public class TestSprawnosci
  {
    private int temp;
    public TestSprawnosci(int temp)
    {
      this.temp = temp;
      if (temp > 40)
        throw new AwariaException("Temperatura > 40");
    }
  }
  public class AwariaException : Exception
  {
    public AwariaException(String msg) : base (msg)
    {
    }
  }
}
