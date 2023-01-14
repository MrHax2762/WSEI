//(C) Michal Turek
public class Program
{
	static void Main(string[] args)
	{
		Cl1 std = new Cl1() { dane1 = 1, dane2 = "tekst"};
	}
}

public class Cl1
{
	public int dane1 { get; set; }
	public string dane2 { get; set; }
}

