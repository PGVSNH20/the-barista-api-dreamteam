using BaristaApi.CoffeeIngridients;

public class Beans : IIngridient
{
    public string Name { get; set; } = "Coffee Beans";
    public string Sort { get; set; }
    public int AmountInG { get; set; }
    public bool Grinded { get; set; }
}