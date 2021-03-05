using BaristaApi.Beverages;
using BaristaApi.Ingredients;
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
        public Bean Bean { get; set; }

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

        public ICoffeeMachine AddBean(string sort, int amount)
        {
            Bean = new Bean()
            {
                Sort = sort,
                Amount = amount
            };
            return this;
        }

        public ICoffeeMachine AddBean(Func<Bean, Bean> beanFunc)
        {
            Bean = new Bean();
            Bean = beanFunc(Bean);
            return this;
        }

        public IBeverage ToBeverage()
        {
            if (CheckRecipe(Ingredients, Espresso.recipe))
            {
                return new Espresso(Ingredients, Bean);
            }
            else if (CheckRecipe(Ingredients, Cappuccino.recipe))
            {
                return new Cappuccino(Ingredients, Bean);
            }
            else if (CheckRecipe(Ingredients, Americano.recipe))
            {
                return new Americano(Ingredients, Bean);
            }
            else if (CheckRecipe(Ingredients, Macchiato.recipe))
            {
                return new Macchiato(Ingredients, Bean);
            }
            else if (CheckRecipe(Ingredients, Mocha.recipe))
            {
                return new Mocha(Ingredients, Bean);
            }
            else if (CheckRecipe(Ingredients, Latte.recipe))
            {
                return new Latte(Ingredients, Bean);
            }

            IBeverage beverage = new CustomDrink(Ingredients, Bean);
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