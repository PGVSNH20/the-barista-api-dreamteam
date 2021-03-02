using System;
using System.Collections.Generic;

public interface IBeverage
{
    List<Ingrident> Ingredients { get; }
    string CupType { get; }
    public Beans Beans { get; }

    public IBeverage AddEspresso(int amount);

    public IBeverage AddMilk(int amount);

    public IBeverage AddMilkFoam(int amount);

    public IBeverage AddChocolateSyrup(int amount);

    public IBeverage AddWater(int amount);

    public IBeverage AddBeans(Func<Beans, Beans> choseBeans);

    public IBeverage ToBeverege();
}
