

public interface ICoffeeRepository
{

    ICoffee GetCoffeeOrder(int orderChoice);

    public bool IsOderValid(int orderChoice);
}
