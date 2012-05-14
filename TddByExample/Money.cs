namespace TddByExample
{
    public class Money : IExpression
    {
        private int _amount;

        public int Amount
        {
            get { return _amount; }
        }

        public string Currency { get; protected set; }

        public Money(int amount, string currency)
        {
            _amount = amount;
            Currency = currency;
        }

        public IExpression Times(int multiplier)
        {
            return new Money(_amount * multiplier, Currency);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return _amount == money._amount && Currency == money.Currency;
        }

        public override string ToString()
        {
            return _amount + " " + Currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        #region IExpression Members

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        #endregion
    }
}