public class OrderDetails
{
    public static int GetOrder()
    {
        if(int.TryParse(Console.ReadLine(), out int output))
        {
            return output;
        }
        return -1;
    }
}