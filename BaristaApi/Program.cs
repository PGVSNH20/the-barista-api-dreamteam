using BaristaApi.CoffeeService;
using System;

namespace BaristaApi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var espresso = new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).ToBeverege();
            ////espresso is type of Espresso

            //var espresso2 = new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).ToBeverege() as Espresso;

            //Latte latte = new Espresso().AddWater(200) as Latte;

            //var testLatte = new Coffe_test().ToBeverege();
            //IBavarege_test testLatte2 = new Coffe_test().ToBeverege();

            ////Latte latte = (Latte)new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).AddMilk(100).ToBeverege() as Latte;
            ////latte is type of Latte

            //Latte latte2 = new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).AddMilk(100).ToBeverege() as Latte;
            var espresso3 = new CoffeeService.CoffeeService().AddEspresso(50).ToBeverege();
            var espresso = new CoffeeService.CoffeeService().AddEspresso(50).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).ToBeverege();
            Espresso espress2 = new CoffeeService.CoffeeService().ToBeverege() as Espresso;
        }
    }
}