namespace BaristaApi.CoffeeIngridients
{
    public class ChocolateSyrup : Ingridient
    {
        public ChocolateSyrup(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public ChocolateSyrup(int amountIng)
        {
            Name = "Chocolate Syrup";
            AmountInG = amountIng;
        }
    }
}