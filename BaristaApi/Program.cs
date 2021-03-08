using BaristaApi.CoffeeService;
using BaristaApi.Ingredients;
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

            //public Bean GetbeanFunc(BeanFunc beanFunc) {
            //    return Bean;
            //};
            var customDrink = new CoffeeMachine().AddMilk().AddChocolateSyrup().AddCustom("socker").ToBeverage();
            var espresso = new CoffeeMachine().AddEspresso().AddBean("Robusta", 100).ToBeverage();
            var cappuccino = new CoffeeMachine().AddEspresso().AddMilkFoam().AddBean(b => { b.Sort = "Robusta"; b.Amount = 100; return b; }).AddMilk().ToBeverage();
            var americano = new CoffeeMachine().AddEspresso().AddWater().AddBean(b => { b.Sort = "Liberica"; b.Amount = 50; return b; }).ToBeverage();
            var macchiato = new CoffeeMachine().AddEspresso().AddMilkFoam().AddBean(b => { b.Sort = "Arabica"; b.Amount = 75; return b; }).ToBeverage();
            var mocha = new CoffeeMachine().AddEspresso().AddChocolateSyrup().AddMilk().ToBeverage();
            var latte = new CoffeeMachine().AddEspresso().AddMilk().ToBeverage();
            
            Console.WriteLine();
        }
    }
}