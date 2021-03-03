namespace BaristaApi.CoffeeIngridients
{
    public interface IIngridient
    {
        public string Name { get; }
        public int AmountInG { get; }
    }
}