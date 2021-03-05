using System;

namespace BaristaApi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var espresso = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 10; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .ToBeverege();
            var doubleEspresso = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .ToBeverege();
            var americano = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddWater(60)
                .ToBeverege();
            var cappuccino = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilkFoam(100)
                .AddMilk(50)
                .ToBeverege();
            var macchiato = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilkFoam(150)
                .ToBeverege();
            var mocha = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilk(150)
                .AddChocolateSyrup(50)
                .ToBeverege();
            var latte = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilk(150)
                .ToBeverege();
            Console.WriteLine("hej");
        }
    }
}