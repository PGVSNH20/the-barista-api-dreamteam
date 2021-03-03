using BaristaApi.CoffeIngridients;

public class Beans : IIngridient
{
    public string Name { get; set; }
    public string Sort { get; set; }
    public int AmountInG { get; set; }
    public bool Grinded { get; set; }
}