using System;
using System.Linq;

namespace EX6
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <2)
            {
                return false;
            }
            return Enumerable.Range(2, (int) Math.Sqrt(number)-1).All(x => number % x != 0);
        }
    }
}