public class CoffeeFactory
{
    public static Coffee CreateCoffeeOrder(string order)
    {
        if(order == "1")
        {
            return new Coffee
            {
                OrderName = "Espresso",
                amt = 60,
            };
        }
        if(order == "2")
        {
            return new Coffee
            {
                OrderName = "Latte",
                amt = 80,
            };
        }
        return null;
    }
}