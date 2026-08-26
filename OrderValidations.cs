public class OrderValidations
{
    public static bool CheckInpOrder(string orderChoice)
    {
        if(orderChoice  != "1" && orderChoice != "2")
        {
            return false;
        }
        return true;
    }
}