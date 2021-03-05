using BaristaApi.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public interface IBeverage
    {
        List<string> Ingredients { get; }
        string CupType { get; }
        Bean Bean { get; }
    }
}