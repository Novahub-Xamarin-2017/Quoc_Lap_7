using System;
using System.Linq;

namespace EX7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            var m = 15;
            var r = new Random();
            Enumerable.Range(1,m).OrderBy(x=>r.Next()).Take(n).ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
