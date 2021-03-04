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
           
            bool isAmericano = CheckRecipe(Ingredients, Americano.recipe);
            bool isMacchiato = CheckRecipe(Ingredients, Macchiato.recipe);

            if (CheckRecipe(Ingredients, Espresso.recipe))
            {
                return new Espresso(Ingredients);
            }

            else if (CheckRecipe(Ingredients, Cappuccino.recipe))
            {
                return new Cappuccino(Ingredients);
            }

            else if (isAmericano)
            {
                return new Americano(Ingredients);
            }

            else if (isMacchiato)
            {
                return new Macchiato(Ingredients);
            }

            IBeverage beverage = new Beverage(Ingredients);
            return beverage;


            
        }
        private bool CheckRecipe(List<string> listOne, List<string> listTwo)
        {
            listOne = listOne.OrderBy(i => i).ToList();
            listTwo = listTwo.OrderBy(i => i).ToList();

            return listOne.SequenceEqual(listTwo);
        }
    }
}