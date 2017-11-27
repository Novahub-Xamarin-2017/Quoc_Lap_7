using System;
using System.Collections.Generic;

namespace Exercise2.models
{
    public class DataGenerator
    {
        public static List<Student> InitStudents()
        => new List<Student>
            {
                new Student(1,"Miracle", 9.5,1,new DateTime(1989,6,10)),
                new Student(2,"Matubaman", 8.5,1,new DateTime(1993,6,8)),
                new Student(3,"Gh", 8.0,1,new DateTime(1992,6,9)),
                new Student(4,"Kuroky", 8.1,1,new DateTime(1990,6,10)),
                new Student(5,"Mind_322", 5.5,1,new DateTime(1991,6,5)),
                new Student(6,"Fight me", 7.5,2,new DateTime(1991,6,1)),
                new Student(7,"Yapzor", 8.5,2,new DateTime(1991,6,16)),
                new Student(8,"MidOne", 9,2,new DateTime(1988,6,17)),
                new Student(9,"Ace", 6.5,2,new DateTime(1989,6,17)),
                new Student(10,"Fata", 4.5,2,new DateTime(1989,6,17)),
                new Student(11,"Eternal Envy", 7,2,new DateTime(1989,6,18)),
            };

        public static List<Class> InitClasses()
            => new List<Class>()
            {
                new Class(1, "Liquid"),
                new Class(2, "Secret")
            };
    }
}