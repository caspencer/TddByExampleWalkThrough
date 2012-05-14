namespace TddByExample
{
    public interface IExpression
    {
        IExpression Plus(IExpression tenFrancs); 
        Money Reduce(Bank bank, string to);
    }
}
