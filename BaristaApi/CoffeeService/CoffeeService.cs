using BaristaApi.CoffeIngridients;
using BaristaApi.CoffeeService;
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
            if (this.Ingredients.Equals(CoffeeRecepes.Espresso))
                return new Espresso(this);
            else if (this.Ingredients.Equals(CoffeeRecepes.Latte))
                return new Latte(this);
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
            CoffeIngridients.Espresso espresso = new CoffeIngridients.Espresso(GenerateIngrident("Espresso", amount));
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
            Ingredients.Add(GenerateIngrident("MilkFoam", amount));
            return this;
        }

        public ICoffeeService AddChocolateSyrup(int amount)
        {
            Ingredients.Add(GenerateIngrident("ChocolateSyrup", amount));
            return this;
        }

        public ICoffeeService AddWater(int amount)
        {
            Ingredients.Add(GenerateIngrident("Water", amount));
            return this;
        }

        public ICoffeeService AddBeans(Func<Beans, Beans> choseBeans)
        {
            Beans = choseBeans(Beans);
            return this;
        }
    }
}