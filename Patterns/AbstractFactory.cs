namespace CoffeeMachine.Patterns;

using CoffeeMachine.Models;

public interface IDrinkProduct
{
    IBeverage CreateDrink();
}

public interface IDessert
{
    string Name { get; }
    decimal Cost { get; }
}

public interface IMenuFactory
{
    IBeverage CreateDrink();
    IDessert CreateDessert();
}

public sealed class Croissant : IDessert
{
    public string Name => "Круассан";
    public decimal Cost => 90m;
}

public sealed class ChocolateMuffin : IDessert
{
    public string Name => "Шоколадный маффин";
    public decimal Cost => 110m;
}

public sealed class MorningMenuFactory : IMenuFactory
{
    public IBeverage CreateDrink()
    {
        return new Espresso();
    }

    public IDessert CreateDessert()
    {
        return new Croissant();
    }
}

public sealed class SweetMenuFactory : IMenuFactory
{
    public IBeverage CreateDrink()
    {
        return new Cocoa();
    }

    public IDessert CreateDessert()
    {
        return new ChocolateMuffin();
    }
}
public sealed class MenuSet
{
    public IBeverage Drink { get; }
    public IDessert Dessert { get; }

    public MenuSet(IMenuFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);

        Drink = factory.CreateDrink();
        Dessert = factory.CreateDessert();
    }

    public decimal TotalCost => Drink.Cost + Dessert.Cost;

    public void Print()
    {
        Console.WriteLine($"Напиток: {Drink.Description}");
        Console.WriteLine($"Десерт: {Dessert.Name}");
        Console.WriteLine($"Стоимость напитка: {Drink.Cost:F2} ₽");
        Console.WriteLine($"Стоимость десерта: {Dessert.Cost:F2} ₽");
        Console.WriteLine($"Стоимость набора: {TotalCost:F2} ₽");
    }
}