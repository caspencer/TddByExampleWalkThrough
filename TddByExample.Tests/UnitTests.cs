using Xunit;

namespace TddByExample.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Multiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2), new MoneyEqualityComparer());
            Assert.Equal(Money.Dollar(15), five.Times(3), new MoneyEqualityComparer());
        }

        [Fact]
        public void FrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.Equal(Money.Franc(10), five.Times(2), new MoneyEqualityComparer());
            Assert.Equal(Money.Franc(15), five.Times(3), new MoneyEqualityComparer());
        }

        [Fact]
        public void Equality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));

            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));

            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void DifferentClassEquality()
        {
            Assert.True(new Money(10, "CHF").Equals(new Franc(10, "CHF")));
        }

        [Fact]
        public void Currency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency);
            Assert.Equal("CHF", Money.Franc(1).Currency);
        }
    }
}