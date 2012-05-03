using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddByExample
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
