using BaristaApi.CoffeeIngridients;
using System.Collections.Generic;

namespace BaristaApi.CoffeeService
{
    public static class CoffeeRecepes
    {
        public static List<IIngridient> Espresso = new List<IIngridient>()
        {
            new EspressoIngr(30)
        };

        public static List<IIngridient> DoubleEspresso = new List<IIngridient>()
        {
            new EspressoIngr(60)
        };

        public static List<IIngridient> Americano = new List<IIngridient>()
        {
            new EspressoIngr(60),
            new Water(60)
        };

        public static List<IIngridient> Cappuccino = new List<IIngridient>()
        {
            new EspressoIngr(60),
            new MilkFoam(100),
            new Milk(50)
        };

        public static List<IIngridient> Macchiato = new List<IIngridient>()
        {
            new EspressoIngr(60),
            new MilkFoam(150),
        };

        public static List<IIngridient> Latte = new List<IIngridient>()
        {
            new EspressoIngr(60),
            new Milk(150),
        };

        public static List<IIngridient> Mocha = new List<IIngridient>()
        {
            new EspressoIngr(60),
            new ChocolateSyrup(50),
            new Milk(150),
        };
    }
}