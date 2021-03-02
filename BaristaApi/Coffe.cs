using System;
using System.Collections.Generic;

internal class Coffe : IBeverage
{
    public List<Ingrident> Ingredients { get; set; }
    public string CupType { get; set; }
    public Beans Beans { get; set; }

    public Coffe()
    {
        Ingredients = new List<Ingrident>();
        Beans = new Beans();
    }

    public IBeverage ToBeverege()
    {
        IBeverage beverage = this;
        return this as IBeverage;
    }

    private Ingrident GenerateIngrident(string name, int amount)
    {
        return new Ingrident()
        {
            IngridentName = name,
            IngridientAmount = amount
        };
    }

    public IBeverage AddEspresso(int amount)
    {
        Ingredients.Add(GenerateIngrident("Espresso", amount));
        return this;
    }

    public IBeverage AddMilk(int amount)
    {
        Ingredients.Add(GenerateIngrident("Milk", amount));
        return this;
    }

    public IBeverage AddMilkFoam(int amount)
    {
        Ingredients.Add(GenerateIngrident("MilkFoam", amount));
        return this;
    }

    public IBeverage AddChocolateSyrup(int amount)
    {
        Ingredients.Add(GenerateIngrident("ChocolateSyrup", amount));
        return this;
    }

    public IBeverage AddWater(int amount)
    {
        Ingredients.Add(GenerateIngrident("Water", amount));
        return this;
    }

    public IBeverage AddBeans(Func<Beans, Beans> choseBeans)
    {
        Beans = choseBeans(Beans);
        return this;
    }
}
