using BaristaApi.CoffeIngridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public static class CoffeeRecepes
    {
        public static List<IIngridient> Espresso = new List<IIngridient>()
        {
            new CoffeIngridients.Espresso(50)
        };

        public static List<IIngridient> Latte = new List<IIngridient>()
        {
            new CoffeIngridients.Espresso(50),
            new MilkFoam(150),
        };
    }
}