using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Steven\Desktop\XAMARIN MOVAHUB";
            var docxFiles = GetAllFiles(path, x => x.EndsWith("docx"));
            docxFiles.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }

        private static IEnumerable<string> GetAllFiles(string path, Predicate<string> filter)
        {
            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if (filter(file))
                {
                    yield return file;
                }
            }
        }
    }
}
