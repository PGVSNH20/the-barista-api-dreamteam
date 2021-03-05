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
        public Beans Beans { get; set; }

        public CoffeeService()
        {
            Ingredients = new List<IIngridient>();
            Beans = new Beans();
        }

        public ICoffee ToBeverege()
        {
            if (Beans.AmountInG <= 0) throw new Exception("No Beans added!");
            else if (Beans.Grinded == false) throw new Exception("Beans not grind!");
            else if (RecipeChecker(this.Ingredients, CoffeeRecepes.Espresso))
                return new CoffeeTypes.Espresso(this);
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

        public ICoffeeService AddEspresso(int amount)
        {
            if (Beans.AmountInG <= 0) throw new Exception("No Beans added!");
            else if (Beans.Grinded == false) throw new Exception("Beans not grind!");
            CoffeeIngridients.EspressoIngr espresso = new CoffeeIngridients.EspressoIngr(GenerateIngrident("Espresso", amount));
            Ingredients.Add(espresso);
            return this;
        }

        public ICoffeeService AddMilk(int amount)
        {
            Ingredients.Add(GenerateIngrident("Milk", amount));
            return this;
        }

        public ICoffeeService AddMilkFoam(int amount)
        {
            Ingredients.Add(GenerateIngrident("Milk Foam", amount));
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

        public ICoffeeService AddBeans(Func<Beans, Beans> defineBeans)
        {
            Beans = defineBeans(Beans);
            return this;
        }

        public ICoffeeService GrindBeans()
        {
            if (Beans.AmountInG > 0) Beans.Grinded = true;
            else throw new Exception("No Beans added!");
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