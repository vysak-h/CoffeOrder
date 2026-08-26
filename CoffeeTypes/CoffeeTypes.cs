

public class Espresso : ICoffee
{
    public string Name => "Esspresso";
    public double price => 60;
}

public class Latte: ICoffee, IAddMilk
{
    public string Name => "Latte";
    public double price => 80;
    public  void AddMilk()
    {
        Console.WriteLine("adding milk");
    }
}
public class Americano: ICoffee
{
    public string Name => "Americano";
    public double price => 75;
}
public class Cappucino: ICoffee
{
    public string Name => "Cappucino";
    public double price => 90;
}