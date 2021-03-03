using BaristaApi.CoffeIngridients;
using System;
using System.Collections.Generic;

internal class Latte : ICoffee
{
    public List<IIngridient> Ingredients { get; set; }
    public string CupType { get; set; }
    public Beans Beans { get; set; }

    public Latte(ICoffee beverage)
    {
        Ingredients = beverage.Ingredients;
        CupType = beverage.CupType;
        Beans = beverage.Beans;
    }
}