using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            var listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var listB = new List<int>() { 3, 5, 9, 11, 13, 15 };

            Console.WriteLine("The list of numbers in common :");
            var commonList = listA.Intersect(listB).ToList();
            commonList.ForEach(Console.WriteLine);

            Console.WriteLine("\n\nThe list of numbers exist from array 1 but array 2 : ");
            listA.Except(listB).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("The list of numbers exist from only one array :");
            listA.Union(listB).Except(commonList).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(listA.Aggregate((a, b) => a * b));

            Console.WriteLine(listA.Aggregate((a, b) => a | b));

            var sum = Enumerable.Range(0, listA.Count - 1)
                .Sum(i => Enumerable.Range(0, listB.Count - 1).Sum(j => (i != j) ? listA[i] * listB[j] : 0));
            Console.WriteLine($"Optional Sum : {sum}");
            Console.ReadKey();
        }
    }
}
