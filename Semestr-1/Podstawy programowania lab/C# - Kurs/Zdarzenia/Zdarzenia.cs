// (C) Michal Turek
using System;
public class Zdarzenia
{
  public static void Main()
  {
    Button b = new Button();
    b.Click += new Button.EventHandler(b_Click);
    b.FrameworkClick();//akcja z framework
    Console.In.ReadLine();
  }
  public static void b_Click()
  {
    Console.WriteLine("Obsluga zdarzenia przycisku.");  
  }
}
public class Button
{
  public delegate void EventHandler();
  public event EventHandler Click;
  public void FrameworkClick()
  {
    Click();
  }
}
