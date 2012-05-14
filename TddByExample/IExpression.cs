namespace TddByExample
{
    public interface IExpression
    {
        Money Reduce(string to);
        Money Reduce(Bank bank, string to);
    }
}
