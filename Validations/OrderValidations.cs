
public class OrderValidations : IinputValidation
{
    private ICoffeeRepository _coffeeRepository;

    public OrderValidations(ICoffeeRepository coffeeRepository)
    {
        _coffeeRepository = coffeeRepository;
    }
    public bool CheckInpOrder(int orderChoice)
    {

        return _coffeeRepository.IsOderValid(orderChoice);
    }
}