using System;
using System.Linq;
using Exercise1.Models;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentGenerator.InitStudents();

            // display student has score >=8 in order of birthday
            Console.WriteLine("students have score >=8 in order of birthday :");
            var goodStudents = students.Where(student => student.Score >= 8).OrderBy(student => student.BirthDate);
            goodStudents.ToList().ForEach(Console.WriteLine);

            // display student has score between 5 and 7.5 in order of name
            Console.WriteLine("\n\nstudents have score between 5 and 7.5 in order of name");
            var mediumStudents = students.Where(student => student.Score >= 5 && student.Score <= 7.5).OrderBy(student => student.Name);
            mediumStudents.ToList().ForEach(Console.WriteLine);

            // display student has score between 6 and 8
            Console.WriteLine("\n\nstudents have score between 6 and 8 in order of name birthday year in (1990-1992)");
            var nearlyGoodStudents = students.Where(student => student.Score >= 6 && student.Score <= 8 && student.BirthDate.Year >= 1990 && student.BirthDate.Year <= 1992);
            nearlyGoodStudents.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }

    }
}
