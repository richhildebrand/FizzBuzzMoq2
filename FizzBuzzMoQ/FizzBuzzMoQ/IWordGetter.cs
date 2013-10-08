namespace FizzBuzzMoQ
{
    public interface IWordGetter
    {
        string GetFizzIfRequired(int number);
        string GetBuzzIfRequired(int number);
    }
}