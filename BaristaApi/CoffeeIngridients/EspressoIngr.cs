namespace BaristaApi.CoffeeIngridients
{
    public class EspressoIngr : Ingridient
    {
        public EspressoIngr(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public EspressoIngr(int amountIng)
        {
            Name = "Espresso";
            AmountInG = amountIng;
        }
    }
}