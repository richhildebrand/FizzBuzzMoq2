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
            throw new NotImplementedException();
        }
    }
}
