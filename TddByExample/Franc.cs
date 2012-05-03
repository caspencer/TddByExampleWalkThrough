﻿namespace TddByExample
{
    public class Franc : Money
    {
        internal Franc(int amount, string currency)
            : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}
