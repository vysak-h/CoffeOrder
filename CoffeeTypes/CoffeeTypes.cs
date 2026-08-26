

public class Espresso : ICoffee
{
    public string Name => "Esspresso";
    public double price => 60;
}

public class Latte: ICoffee
{
    public string Name => "Latte";
    public double price => 80;
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