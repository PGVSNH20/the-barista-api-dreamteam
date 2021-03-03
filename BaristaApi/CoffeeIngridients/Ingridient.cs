using BaristaApi.CoffeeIngridients;
using System;

public class Ingridient : IIngridient, IComparable
{
    public string Name { get; set; }
    public int AmountInG { get; set; }

    public int CompareTo(object obj)
    {
        IIngridient ingridient = (IIngridient)obj;
        return String.Compare(this.Name, ingridient.Name);
    }
}