using BaristaApi.CoffeeService;
using System;

namespace BaristaApi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            //Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
            var espresso = new CoffeeMachine().AddEspresso().ToBeverage();
            var cappuccino = new CoffeeMachine().AddEspresso().AddMilkFoam().AddMilk().ToBeverage();
            var americano = new CoffeeMachine().AddEspresso().AddWater().ToBeverage();
            Console.WriteLine();
        }
    }
}