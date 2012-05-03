using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace TddByExample.Tests
{
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
