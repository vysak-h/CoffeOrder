public class OrderMessages
{
    public static void InputMsg()
    {
        Console.WriteLine("Please provide your input");
    }
    public static void InputValidaMsg()
    {
        Console.WriteLine("Please provide a valid Input!");
    }
    public static void showOrderBill(ICoffee coffee)
    {
        Console.WriteLine($"You have selected {coffee.Name} , and your total is {coffee.price} \n Thank you😀");
    }
}