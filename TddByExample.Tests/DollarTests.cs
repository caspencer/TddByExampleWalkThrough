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
    // [X] Make "amount" private
    // [X] Dollar side-effects?
    // [ ] Money rounding?
    // [X] Equals()
    // [ ] GetHashCode()

    public class DollarTests
    {
        [Fact]
        public void Multiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));            
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void Equality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
