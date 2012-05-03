﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddByExample
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}