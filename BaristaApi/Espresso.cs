using System;
using System.Collections.Generic;

internal class Espresso : IBeverage
{
    public List<Ingrident> Ingredients { get; }
    public string CupType { get; }
    public Beans Beans { get; }

    public IBeverage AddBeans(Func<Beans, Beans> choseBeans)
    {
        throw new NotImplementedException();
    }

    public IBeverage AddChocolateSyrup(int amount)
    {
        throw new NotImplementedException();
    }

    public IBeverage AddEspresso(int amount)
    {
        throw new NotImplementedException();
    }

    public IBeverage AddMilk(int amount)
    {
        throw new NotImplementedException();
    }

    public IBeverage AddMilkFoam(int amount)
    {
        throw new NotImplementedException();
    }

    public IBeverage AddWater(int amount)
    {
        throw new NotImplementedException();
    }

    public IBeverage ToBeverege()
    {
        throw new NotImplementedException();
    }
}