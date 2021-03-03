namespace BaristaApi.CoffeeIngridients
{
    public class Water : IIngridient
    {
        public string Name { get; set; }
        public int AmountInG { get; set; }
        public int Temperature { get; set; }

        public Water(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public Water(int amountIng)
        {
            Name = "Water";
            AmountInG = amountIng;
            Temperature = 80;
        }
    }
}