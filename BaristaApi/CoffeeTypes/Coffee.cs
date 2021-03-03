using BaristaApi.CoffeeIngridients;
using BaristaApi.CoffeeTypes;
using System.Collections.Generic;

public class Coffee : ICoffee
{
    public List<IIngridient> Ingredients { get; set; }
    public string CupType { get; set; }
    public Beans Beans { get; set; }

    public Coffee(ICoffee beverage)
    {
        Ingredients = beverage.Ingredients;
        CupType = beverage.CupType;
        Beans = beverage.Beans;
    }
}