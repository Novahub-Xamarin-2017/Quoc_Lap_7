using System;
using System.Linq;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 30;
            var primeNumbers = Enumerable.Range(2, number-1).Where(x => x.IsPrime());
            primeNumbers.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
