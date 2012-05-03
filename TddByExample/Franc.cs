namespace TddByExample
{
    public class Franc : Money
    {
        internal Franc(int amount)
        {
            Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
