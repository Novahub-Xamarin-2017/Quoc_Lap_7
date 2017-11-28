using System;
using System.Collections.Generic;
using System.Linq;
using Exercise2.Models;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = DataGenerator.InitStudents();
            var classes = DataGenerator.InitClasses();
            DisplayClassWithStudentCount(students, classes);
            DisplayClassWithHighestScore(students, classes);
            DisplayClassWithAverageScore(students, classes);
            DisplayTop10Students(students);
            DisplayTop3EachClass(students, classes);
            Display10RandomStudents(students);
            Console.ReadKey();
        }

        private static void DisplayClassWithStudentCount(List<Student> students, List<Class> classes)
        {
            var classWithStudentCount = classes.Select(c => new
            {
                c,
                StudentCount = students.Count(s => s.ClassId == c.Id)
            });
            Console.WriteLine("Classes with student count :");
            classWithStudentCount.ToList().ForEach(Console.WriteLine);
        }
        private static void DisplayClassWithHighestScore(List<Student> students, List<Class> classes)
        {
            var classWithHighestScore = classes.Select(c => new
            {
                c,
                HighestScore = students.Where(s => s.ClassId == c.Id).Max(s => s.Score)
            });
            Console.WriteLine("\nClasses with highest score :");
            classWithHighestScore.ToList().ForEach(Console.WriteLine);
        }
        private static void DisplayClassWithAverageScore(List<Student> students, List<Class> classes)
        {
            var classWithHighestScore = classes.Select(c => new
            {
                c,
                HighestScore = students.Where(s => s.ClassId == c.Id).Average(s => s.Score)
            });
            Console.WriteLine("\nClasses with average score :");
            classWithHighestScore.ToList().ForEach(Console.WriteLine);
        }

        private static void DisplayTop10Students(List<Student> students)
        {
            Console.WriteLine("\nTop 10 students : ");
            var top10Students = students.OrderByDescending(s => s.Score).Take(10)
                .Select((s, i) => new
                {
                    Index = i + 1,
                    s
                });
            top10Students.ToList().ForEach(Console.WriteLine);
        }

        private static void DisplayTop3EachClass(List<Student> students, List<Class> classes)
        {
            Console.WriteLine("\nTop 3 students each class who has score >=8 :");
            var filteredClasses = students.GroupBy(s => s.ClassId);
            foreach (var filteredClass in filteredClasses)
            {
                Console.WriteLine($"\tClass : {classes.Single(c => c.Id == filteredClass.Key).Name}");
                var top3Students = filteredClass.OrderByDescending(s => s.Score).Take(3)
                    .TakeWhile(s => s.Score >= 8).Select((s, i) => new
                    {
                        Index = i + 1,
                        s
                    });
                top3Students.ToList().ForEach(Console.WriteLine);
            }
        }

        private static void Display10RandomStudents(List<Student> students)
        {
            Random r = new Random();
            var randomStudents = students.OrderBy(s => r.Next()).Take(10).Select((s, i) => new
            {
                Index = i + 1,
                s
            });
            Console.WriteLine("\n10 random students : ");
            randomStudents.ToList().ForEach(Console.WriteLine);
        }
    }
}
