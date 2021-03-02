using System.Collections.Generic;

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}
public class Ingrident{
    public string IngridentName {get; set;}
    public int IngridientAmount {get; set;}
}

class Espresso : IBeverage
{
    public List<Ingrident> Ingredients {get; set;}
}

class Latte : IBeverage
{
    public Ingrident Espresso = new Ingrident {
        IngridentName = "Espresso", IngridientAmount = 50;
    }
    public Ingrident Milk = new Ingrident {
        IngridentName = "Milk", IngridientAmount = 150;
    }
    public List<string> Ingredients => new List<string>();
    public IBeverage AddIngrident(IIngrident ingrient){
        Ingredients.Add(ingridient);
        return this;
    }

    public string CupType => throw new System.NotImplementedException();
}