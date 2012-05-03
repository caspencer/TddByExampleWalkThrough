using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddByExample
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount;
        }
    }
}
