namespace TddByExample
{
    public class Money : IExpression
    {
        protected int Amount;

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public string Currency { get; protected set; }

        public Money Times(int multiplier)
        {
            return new Money(Amount*multiplier, Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Money(Amount + addend.Amount, Currency);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && Currency == money.Currency;
        }

        public override string ToString()
        {
            return Amount + " " + Currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}