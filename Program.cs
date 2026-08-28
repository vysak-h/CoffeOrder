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

        ICoffeeRepository coffeeRepository = new CoffeeList();

        IinputValidation iinputValidation = new OrderValidations(coffeeRepository);

        bool isValidInput = iinputValidation.CheckInpOrder(orderChoice);

        if(!isValidInput)
        {
            OrderMessages.InputValidaMsg();
            return;
        }

        var coffeeOrder = coffeeRepository.GetCoffeeOrder(orderChoice);

        // ICoffee coffee = CoffeeFactory.CreateCoffeeOrder(coffeeType);

        OrderMessages.showOrderBill(coffeeOrder);
    }
}