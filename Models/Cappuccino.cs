namespace CoffeeMachine.Models;

public sealed class Cappuccino : IBeverage
{
    public string Description => "Капучино";

    public decimal Cost => 180m;
}