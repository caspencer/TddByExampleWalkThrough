namespace TddByExample
{
    public class Dollar : Money
    {
        internal Dollar(int amount)
        {
            Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
