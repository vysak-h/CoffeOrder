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
    public static void showOrderBill(Coffee coffee)
    {
        Console.WriteLine($"You have selected {coffee.OrderName} , and your total is {coffee.amt} \n Thank you😀");
    }
}