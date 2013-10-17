using System;
using System.Linq;

namespace FizzBuzzMoQ
{
    public class App
    {
        private readonly IWordGetter _wordGetter;

        public App(IWordGetter wordGetter)
        {
            this._wordGetter = wordGetter;
        }

        public string Run(int number)
        {
            string fizzedNumber = _wordGetter.GetFizzIfRequired(number);
            if(fizzedNumber.Equals(number.ToString()))
            {
                return _wordGetter.GetBuzzIfRequired(number);
            }
            return fizzedNumber + _wordGetter.GetBuzzIfRequired(number);
        }
    }
}
