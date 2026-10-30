namespace CoffeeMachine.Models;

public sealed class Espresso : IBeverage
{
    public string Description => "Эспрессо";

    public decimal Cost => 120m;
}