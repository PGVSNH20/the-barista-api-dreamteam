﻿namespace BaristaApi.CoffeeIngridients
{
    public class Espresso : Ingridient
    {
        public Espresso(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public Espresso(int amountIng)
        {
            Name = "Espresso";
            AmountInG = amountIng;
        }
    }
}