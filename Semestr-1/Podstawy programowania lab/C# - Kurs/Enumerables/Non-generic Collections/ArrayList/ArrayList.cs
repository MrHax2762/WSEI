// (C) Michal Turek
using System;
using System.Collections;
using System.Collections.Generic;
  
class Cl1 {
  
    public static void Main()
    {
        ArrayList lista = new ArrayList();
        lista.Add("test1");
        lista.Add("test2");
        lista.Add("test3");
        lista.Add(10);
        
        Console.WriteLine("Capacity : " + lista.Capacity);
        Console.WriteLine("Count : " + lista.Count);
        
        Console.WriteLine("String[0] : " + lista[0]);
        Console.WriteLine("String-Array[0] : " + lista.ToArray()[0]);
        Console.WriteLine("String-Array[0] : " + lista.ToArray()[0].ToString());
        
        Console.WriteLine("int[3] : " + lista.ToArray()[3]);
        Console.WriteLine("string representation[3] : " + lista.ToArray()[3].ToString());
        
        lista.RemoveAt(1);
        String s = "str";
        lista.Add(s);
        lista.Remove(s);
        
        Console.In.Read();
    }
}
