// (C) Michal Turek
using System;
namespace p2
{
    public class P1
    {
        public int dane;
        public static P1 operator +(P1 x, P1 y)
        {
            P1 p = new P1();
            p.dane = x.dane + y.dane;
            return p;
        }
        public static P1 operator +(P1 o1, int o2)
        {
            P1 p = new P1();
            p.dane = o1.dane + o2;
            return p;
        }
        public static P1 operator ++(P1 o1)
        {
            o1.dane++;
            return o1;
        }
        public static explicit operator int (P1 o1)
        {
            return o1.dane + 100;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            P1 o1 = new P1(); o1.dane = 10;
            P1 o2 = new P1(); o2.dane = 15;
            P1 o4 = o1 + o1;
            P1 o5 = o1 + 10;
            o5++;
            ++o5;
            P1 o3 = o1+++o2+6;
            Console.WriteLine("Wynik " + (o5++).dane);
            Console.WriteLine("Wynik explicite" + (int)o5);
            Console.ReadKey(true);
        }
    }
}
