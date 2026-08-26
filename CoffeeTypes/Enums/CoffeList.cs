
public class CoffeeList
{
    public Dictionary< int, ICoffee> Coffees { get; } = new (){
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

    public  ICoffee GetCoffeeOrder(int orderChoice)
    {
        return Coffees[orderChoice];
    }
}