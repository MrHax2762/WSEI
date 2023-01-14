using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // wytworzenie zawartości kontenera
        //Skladnik może byc Kontenerem lub tylko Komponentem

        Kontener korzen = new Kontener("Kontener glowny");
        korzen.Add(new Komponent("Komponent A"));
        korzen.Add(new Komponent("Komponent B"));
        korzen.Add(new Komponent("Komponent C"));


        Kontener kon = new Kontener("Kontener pierwszy");
        kon.Add(new Komponent("Komponent A"));
        kon.Add(new Komponent("Komponent B"));
        kon.Add(new Komponent("Komponent C"));
        korzen.Add(kon);
        korzen.Add(new Komponent("Komponent pierwszy"));

        Komponent komponent = new Komponent("Komponent D");
        komponent.Add(new Komponent("Komponent zly")); // test dodawania
        korzen.Add(komponent);
        korzen.Remove(komponent);

        korzen.Display(1);
        Console.ReadKey();
    }
}
abstract class Skladnik
{
    protected string name;
    public Skladnik(string name)
    {
        this.name = name;
    }

    public abstract void Add(Skladnik c);
    public abstract void Remove(Skladnik c);
    public abstract void Display(int zagniezdzenie);
}

class Kontener : Skladnik
{
    private List<Skladnik> skladniki = new List<Skladnik>();
    public Kontener(string name)
        : base(name)
    {
    }
    public override void Add(Skladnik Skladnik)
    {
        skladniki.Add(Skladnik);
    }

    public override void Remove(Skladnik Skladnik)
    {
        skladniki.Remove(Skladnik);
    }

    public override void Display(int zagniezdzenie)
    {
            Console.WriteLine(new String('>', zagniezdzenie) + name);
            foreach (Skladnik Skladnik in skladniki)
            {
                Skladnik.Display(zagniezdzenie + 1);
            }
    }
}



class Komponent : Skladnik

{

    public Komponent(string name)
      : base(name)
    {
    }

    public override void Add(Skladnik c)
    {
        Console.WriteLine("Do Komponentu nie mozna dodawac");
    }

    public override void Remove(Skladnik c)
    {
        Console.WriteLine("Z Komponentu nie mozna usunac");
    }

    public override void Display(int zagniezdzenie)
    {
        Console.WriteLine(new String('>', zagniezdzenie) + name);
    }
}
