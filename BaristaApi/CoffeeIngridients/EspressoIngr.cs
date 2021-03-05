namespace BaristaApi.CoffeeIngridients
{
    public class EspressoIngr : Ingridient
    {
        private string BeanSort { set; get; }

        public EspressoIngr(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public EspressoIngr(int amountIng)
        {
            Name = "Espresso";
            AmountInG = amountIng;
            BeanSort = null;
        }

        public EspressoIngr(int amountIng, string beanSort)
        {
            Name = "Espresso";
            AmountInG = amountIng;
            BeanSort = beanSort;
        }
    }
}