using System;
using System.Linq;

namespace FizzBuzzMoQ
{
    public class Calculator : ICalculator
    {
        public bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        public bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
