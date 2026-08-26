// Console.WriteLine("Hello, World!");

//coffee order system
//print menu
//take order
//print order
//thank you message

public class CoffeeOrder
{
    public  static void Main()
    {
        //order menu
        CoffeeMenu.ShowMenu();
        OrderMessages.InputMsg();

        Coffee coffee = new Coffee();

        string orderChoice = OrderDetails.GetOrder();

        bool isValidInput = OrderValidations.CheckInpOrder(orderChoice);

        if(!isValidInput)
        {
            OrderMessages.InputValidaMsg();
            return;
        }

        coffee = CoffeeFactory.CreateCoffeeOrder(orderChoice);

        OrderMessages.showOrderBill(coffee);
    }
}