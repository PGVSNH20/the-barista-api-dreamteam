using System.Collections.Generic;

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}
public interface IIngrident{
    public string IngridentName {get;}
    public int IngridientAmount {get;}
}

class Espresso : IBeverage
{
    public List<IIngrident> Ingredients {get; set;}
}

class Latte : IBeverage
{
    public List<string> Ingredients => new List<string>();
    public IBeverage AddIngrident(IIngrident ingrient){
        Ingredients.Add("water");
        return this;
    }
    public IBeverage AddBeans(int amount){
        Ingredients.Add("beans");
        return this;
    }

    public string CupType => throw new System.NotImplementedException();
}