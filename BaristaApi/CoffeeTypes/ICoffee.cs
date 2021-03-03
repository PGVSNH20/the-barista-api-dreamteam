using BaristaApi.CoffeIngridients;
using System;
using System.Collections.Generic;

public interface ICoffee
{
    public List<IIngridient> Ingredients { get; }
    public string CupType { get; }
    public Beans Beans { get; }
}