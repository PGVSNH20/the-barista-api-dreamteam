﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    internal interface IBeverege
    {
        List<string> Ingredients { get; }
        string CupType { get; }
    }
}