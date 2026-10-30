using System.Globalization;
using CoffeeMachine.Models;
using CoffeeMachine.Patterns;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("КОФЕЙНЫЙ АППАРАТ");

Console.WriteLine("\n1. Базовые напитки");

IBeverage espresso = new Espresso();
IBeverage cappuccino = new Cappuccino();
IBeverage cocoa = new Cocoa();

PrintBeverage(espresso);
PrintBeverage(cappuccino);
PrintBeverage(cocoa);

Console.WriteLine("\n2. Напитки с добавками");

IBeverage drink1 = new Espresso();
drink1 = new MilkDecorator(drink1);
drink1 = new SugarDecorator(drink1);

PrintBeverage(drink1);
IBeverage drink2 = new Cappuccino();
drink2 = new CinnamonDecorator(drink2);
drink2 = new CreamDecorator(drink2);

PrintBeverage(drink2);
IBeverage drink3 = new Cocoa();
drink3 = new MilkDecorator(drink3);
drink3 = new SugarDecorator(drink3);
drink3 = new CinnamonDecorator(drink3);
drink3 = new CreamDecorator(drink3);

PrintBeverage(drink3);

Console.WriteLine("\n3. Готовые наборы");

Console.WriteLine("\nУтреннее меню:");
IMenuFactory morningFactory = new MorningMenuFactory();
MenuSet morningMenu = new MenuSet(morningFactory);
morningMenu.Print();

Console.WriteLine("\nСладкое меню:");
IMenuFactory sweetFactory = new SweetMenuFactory();
MenuSet sweetMenu = new MenuSet(sweetFactory);
sweetMenu.Print();

Console.WriteLine("Демонстрация завершена.");

static void PrintBeverage(IBeverage beverage)
{
    Console.WriteLine($"Напиток: {beverage.Description}");
    Console.WriteLine($"Цена: {beverage.Cost:F2} ₽");
    Console.WriteLine();
}