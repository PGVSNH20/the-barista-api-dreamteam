using System;

namespace BaristaApi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var espresso = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 100; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(200)
                .ToBeverege();
            var americano = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 50; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(100)
                .AddWater(100)
                .ToBeverege();
            var cappuccino = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 50; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(50)
                .AddMilkFoam(100)
                .AddMilk(50)
                .ToBeverege();
            var macchiato = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 75; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(50)
                .AddMilkFoam(150)
                .ToBeverege();
            var mocha = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 75; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(50)
                .AddMilk(150)
                .AddChocolateSyrup(50)
                .ToBeverege();
            var latte = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 50; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(50)
                .AddMilk(150)
                .ToBeverege();
            Console.WriteLine("hej");
        }
    }
}