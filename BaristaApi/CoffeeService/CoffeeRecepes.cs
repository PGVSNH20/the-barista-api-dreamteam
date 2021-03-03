using BaristaApi.CoffeeIngridients;
using System.Collections.Generic;

namespace BaristaApi.CoffeeService
{
    public static class CoffeeRecepes
    {
        public static List<IIngridient> Espresso = new List<IIngridient>()
        {
            new CoffeeIngridients.Espresso(200)
        };

        public static List<IIngridient> Americano = new List<IIngridient>()
        {
            new CoffeeIngridients.Espresso(100),
            new Water(100)
        };

        public static List<IIngridient> Cappuccino = new List<IIngridient>()
        {
            new CoffeeIngridients.Espresso(50),
            new MilkFoam(100),
            new Milk(50)
        };

        public static List<IIngridient> Macchiato = new List<IIngridient>()
        {
            new CoffeeIngridients.Espresso(50),
            new MilkFoam(150),
        };

        public static List<IIngridient> Latte = new List<IIngridient>()
        {
            new CoffeeIngridients.Espresso(50),
            new Milk(150),
        };

        public static List<IIngridient> Mocha = new List<IIngridient>()
        {
            new CoffeeIngridients.Espresso(50),
            new ChocolateSyrup(50),
            new Milk(150),
        };
    }
}