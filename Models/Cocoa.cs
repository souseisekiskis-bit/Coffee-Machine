namespace CoffeeMachine.Models;

public sealed class Cocoa : IBeverage
{
    public string Description => "Какао";

    public decimal Cost => 150m;
}