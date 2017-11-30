using System;
using System.Collections.Generic;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var subList = numbers.SubList(4);
            foreach (var list in subList)
            {
                list.ForEach(Console.Write);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
