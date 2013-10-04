using System;
using System.Linq;

namespace FizzBuzzMoQ
{
    public class Calculator
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
            return true;
        }
    }
}
