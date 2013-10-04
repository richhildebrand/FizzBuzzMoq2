using System;
using System.Linq;

namespace FizzBuzzMoQ
{
    public class Calculator : ICalculator
    {
        public bool IsDivisibleByThree(int number)
        {
            if (number / 3 == (double)number / 3)
            {
                return true;
            }
            return false;
        }

        public bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
