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

        int orderChoice = OrderDetails.GetOrder();

        bool isValidInput = OrderValidations.CheckInpOrder(orderChoice);

        if(!isValidInput)
        {
            OrderMessages.InputValidaMsg();
            return;
        }
        
        CoffeeList coffeeList = new CoffeeList();
        var coffeeOrder = coffeeList.GetCoffeeOrder(orderChoice);

        // ICoffee coffee = CoffeeFactory.CreateCoffeeOrder(coffeeType);

        OrderMessages.showOrderBill(coffeeOrder);
    }
}