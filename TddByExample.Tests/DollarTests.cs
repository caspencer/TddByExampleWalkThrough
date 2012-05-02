using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace TddByExample.Tests
{
    // TODO LIST:
    // [ ] $5 + 10 CHF = $10 if rate is 2:1
    // [X] $5 x 2 = $10
    // [ ] Make "Amount" private
    // [X] Dollar side-effects?
    // [ ] Money rounding?

    public class DollarTests
    {
        [Fact]
        public void Multiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }
    }
}
