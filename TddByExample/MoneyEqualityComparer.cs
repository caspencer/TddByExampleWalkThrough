using System;
using System.Collections.Generic;

namespace TddByExample
{
    public class MoneyEqualityComparer : IEqualityComparer<Money>
    {
        #region IEqualityComparer<Money> Members

        public bool Equals(Money x, Money y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Money obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}