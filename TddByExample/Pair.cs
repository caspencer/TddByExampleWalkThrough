namespace TddByExample
{
    public class Pair
    {
        public string From { get; private set; }
        public string To { get; private set; }

        public Pair(string from, string to)
        {
            From = from;
            To = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair) obj;
            return From == pair.From && To == pair.To;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    } 
}
