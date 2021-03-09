using BaristaApi.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public interface IBeverage
    {
        List<string> Ingredients { get; }

        [Description("This is the cup type not used in this program")]
        string CupType { get; }

        Bean Bean { get; }

        void PrintBeverageTag();
    }
}