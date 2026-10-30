namespace CoffeeMachine.Patterns;

using CoffeeMachine.Models;

public abstract class BeverageDecorator : IBeverage
{
    protected readonly IBeverage Inner;

    protected BeverageDecorator(IBeverage beverage)
    {
        Inner = beverage
            ?? throw new ArgumentNullException(nameof(beverage));
    }

    public abstract string Description { get; }
    public abstract decimal Cost { get; }
}

public sealed class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    public override string Description =>
        Inner.Description + ", молоко";

    public override decimal Cost =>
        Inner.Cost + 30m;
}

public sealed class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage) { }

    public override string Description =>
        Inner.Description + ", сахар";

    public override decimal Cost =>
        Inner.Cost + 10m;
}

public sealed class CinnamonDecorator : BeverageDecorator
{
    public CinnamonDecorator(IBeverage beverage) : base(beverage) { }

    public override string Description =>
        Inner.Description + ", корица";

    public override decimal Cost =>
        Inner.Cost + 15m;
}

public sealed class CreamDecorator : BeverageDecorator
{
    public CreamDecorator(IBeverage beverage) : base(beverage) { }

    public override string Description =>
        Inner.Description + ", сливки";

    public override decimal Cost =>
        Inner.Cost + 40m;
}