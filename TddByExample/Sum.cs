namespace TddByExample
{
    public class Sum : IExpression
    {
        public Money Augend { get; private set; }
        public Money Addend { get; private set; }

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }
    
        public Money Reduce(string to)
        {
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}
