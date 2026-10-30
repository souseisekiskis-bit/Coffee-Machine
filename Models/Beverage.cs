namespace CoffeeMachine.Models;

public interface IBeverage
{
    string Description { get; }
    decimal Cost { get; }
}