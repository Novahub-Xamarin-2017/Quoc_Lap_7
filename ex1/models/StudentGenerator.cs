namespace ex1.models
{
    public class StudentGenerator
    {
        public static List<Student> InitStudents()
        => new List<Student>
            {
                new Student(1,"Miracle", 9.5,"Liquid",new DateTime(1989,6,10)),
                new Student(2,"Matubaman", 8.5,"Liquid",new DateTime(1993,6,8)),
                new Student(3,"Gh", 7.5,"Liquid",new DateTime(1992,6,9)),
                new Student(4,"Kuroky", 6.5,"Liquid",new DateTime(1990,6,10)),
                new Student(5,"Mind_322", 5.5,"Liquid",new DateTime(1991,6,5)),

            };
    }
}