namespace BaristaApi.CoffeeIngridients
{
    public class MilkFoam : Ingridient
    {
        public string FatPercentage { get; set; }

        public MilkFoam(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public MilkFoam(int amountIng)
        {
            Name = "Milk Foam";
            AmountInG = amountIng;
            FatPercentage = "1,5%";
        }
    }
}