﻿using Xunit;

namespace TddByExample.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Multiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        [Fact]
        public void Equality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void Currency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency);
            Assert.Equal("CHF", Money.Franc(1).Currency);
        }

        [Fact]
        public void SimpleAddition()
        {
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(10), reduced);
        }

        [Fact]
        public void PlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            IExpression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.Equal(five, sum.Augend);
            Assert.Equal(five, sum.Addend);
        }

        [Fact]
        public void ReduceSum()
        {
            IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), result);
        }

        [Fact]
        public void ReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }
    }
}