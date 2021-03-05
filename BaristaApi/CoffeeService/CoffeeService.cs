using BaristaApi.CoffeeIngridients;
using System;
using System.Collections.Generic;
using BaristaApi.CoffeeTypes;

namespace BaristaApi.CoffeeService
{
    public class CoffeeService : ICoffeeService, ICoffee
    {
        public List<IIngridient> Ingredients { get; set; }
        public string CupType { get; set; }
        private EspressoMachine EspressoMachine { get; set; }

        public CoffeeService()
        {
            Ingredients = new List<IIngridient>();
            EspressoMachine = new EspressoMachine();
        }

        public ICoffee ToBeverege()
        {
            if (EspressoMachine.Beans.AmountInG <= 0) throw new Exception("No Beans added!");
            else if (EspressoMachine.Beans.Grinded == false) throw new Exception("Beans not grind!");
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Espresso))
                return new Espresso(this);
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.DoubleEspresso))
                return new DoubleEspresso(this);
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Americano))
                return new Americano(this);
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Cappuccino))
                return new Cappuccino(this);
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Macchiato))
                return new Macchiato(this);
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Latte))
                return new Latte(this);
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Mocha))
                return new Mocha(this);
            else return new UnknowBeverage(this);
        }

        public Ingridient GenerateIngrident(string name, int amount)
        {
            return new Ingridient()
            {
                Name = name,
                AmountInG = amount
            };
        }

        public ICoffeeService AddEspresso()
        {
            Ingredients.Add(EspressoMachine.MakeEspresso());
            return this;
        }

        public ICoffeeService AddMilk(int amount)
        {
            Ingredients.Add(new Milk(amount));
            return this;
        }

        public ICoffeeService AddMilkFoam(int amount)
        {
            Milk milk = new Milk(amount / 2);
            Ingredients.Add(EspressoMachine.FoamMilk(milk));
            return this;
        }

        public ICoffeeService AddChocolateSyrup(int amount)
        {
            Ingredients.Add(GenerateIngrident("Chocolate Syrup", amount));
            return this;
        }

        public ICoffeeService AddWater(int amount)
        {
            Ingredients.Add(GenerateIngrident("Water", amount));
            return this;
        }

        public ICoffeeService AddBeans(Func<Beans, Beans> choseBeans)
        {
            EspressoMachine.AddBeans(choseBeans);
            return this;
        }

        public ICoffeeService GrindBeans()
        {
            EspressoMachine.GrindBeans();
            return this;
        }

        private static bool RecipeChecker(List<IIngridient> ingredients, List<IIngridient> recipe)
        {
            if (ingredients.Count != recipe.Count) return false;
            else
            {
                recipe.Sort();
                ingredients.Sort();
                for (int i = 0; i < recipe.Count; i++)
                {
                    var ingrNameMatch = recipe[i].Name == ingredients[i].Name;
                    var ingrAmountMatch = recipe[i].AmountInG == ingredients[i].AmountInG;
                    if (!ingrNameMatch || !ingrAmountMatch) return false;
                }
            }
            return true;
        }
    }
}