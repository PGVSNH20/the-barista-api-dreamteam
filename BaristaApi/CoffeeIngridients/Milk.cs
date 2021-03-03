namespace BaristaApi.CoffeeIngridients
{
    internal class Milk : IIngridient
    {
        public string Name { get; set; } = "Milk";
        public int AmountInG { get; set; }
        public string FatPercentage { get; set; }

        public Milk(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public Milk(int amountIng)
        {
            Name = "Milk";
            AmountInG = amountIng;
            FatPercentage = "1,5%";
        }
    }
}