using System;
using System.Linq;

namespace FizzBuzzMoQ
{
    public class WordGetter : IWordGetter
    {
        private readonly ICalculator _calculator;

        public WordGetter(ICalculator calculator)
        {
            this._calculator = calculator;
        }

        public string GetBuzzIfRequired(int number)
        {
            return _calculator.IsDivisibleByFive(number) ? "Buzz" : number.ToString();
        }

        public string GetFizzIfRequired(int number)
        {
            return _calculator.IsDivisibleByThree(number) ? "Fizz" : number.ToString();
        }
    }
}
