﻿namespace TddByExample
{
    public class Dollar : Money
    {
        internal Dollar(int amount, string currency)
            : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }
    }
}
