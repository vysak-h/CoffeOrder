
public class CoffeeList : ICoffeeRepository

{
    private readonly Dictionary<int, ICoffee> Coffees = new(){
        {
            1, new Espresso()
        },
        {
            2, new Latte()
        },
        {
            3, new Americano()
        },
        {
            4, new Cappucino()
        }
    };

    public ICoffee GetCoffeeOrder(int orderChoice)
    {
        return Coffees[orderChoice];
    }
    
    public bool IsOderValid(int orderChoice)
    {
        return Coffees.ContainsKey(orderChoice);
    }
}