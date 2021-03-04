using BaristaApi.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public class CoffeeMachine : IBeverage, ICoffeeMachine
    {
        public List<string> Ingredients { get; set; }
        public string CupType { get; set; }
        public CoffeeMachine()
        {
            Ingredients = new List<string>();
        }
        public ICoffeeMachine AddChocolateSyrup()
        {
            Ingredients.Add("Chocolate Syrup");
            return this;
        }

        public ICoffeeMachine AddEspresso()
        {
            Ingredients.Add("Espresso");
            return this;
        }

        public ICoffeeMachine AddMilk()
        {
            Ingredients.Add("Milk");
            return this;
        }

        public ICoffeeMachine AddMilkFoam()
        {
            Ingredients.Add("Milk Foam");
            return this;
        }

        public ICoffeeMachine AddWater()
        {
            Ingredients.Add("Water");
            return this;
        }

        public IBeverage ToBeverage()
        {
            bool isEspresso = Ingredients.SequenceEqual(Espresso.recipe);
            if (isEspresso)
            {
                return new Espresso(Ingredients);
            }

            IBeverage beverage = new Beverage(Ingredients);
            return beverage;
            
        }
    }
}