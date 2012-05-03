using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace TddByExample.Tests
{
    public class FrancTests
    {
        [Fact]
        public void Multiplication()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }
    }
}
