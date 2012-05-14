namespace TddByExample
{
    public class Sum : IExpression
    {
        public IExpression Augend { get; private set; }
        public IExpression Addend { get; private set; }

        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        #region IExpression Members

        public IExpression Plus(IExpression tenFrancs)
        {
            return null;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        #endregion
    }
}
