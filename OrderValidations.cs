public class OrderValidations
{
    public static bool CheckInpOrder(int orderChoice)
    {
        CoffeeList coffeeList = new CoffeeList();
        if(!coffeeList.Coffees.ContainsKey(orderChoice))
        {
            return false;
        }
        return true;
    }
}