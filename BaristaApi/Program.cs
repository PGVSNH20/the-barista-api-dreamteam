using System;

namespace BaristaApi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var espresso = new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).ToBeverege();
            //espresso is type of Espresso

            var espresso2 = new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).ToBeverege() as Espresso;

            //Latte latte = (Latte)new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).AddMilk(100).ToBeverege() as Latte;
            //latte is type of Latte

            Latte latte2 = new Coffe().AddWater(20).AddBeans(b => { b.AmountInG = 7; b.Sort = "Robusta"; return b; }).AddMilk(100).ToBeverege() as Latte;
        }
    }
}