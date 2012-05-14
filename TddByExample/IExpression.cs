namespace TddByExample
{
    public interface IExpression
    {
        IExpression Plus(IExpression addend); 
        Money Reduce(Bank bank, string to);
        IExpression Times(int multiplier); 
    }
}
