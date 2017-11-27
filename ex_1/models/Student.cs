using System;

namespace Exercise1.models
{
    public class Student : EasyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public string ClassId { get; set; }
        public DateTime BirthDate { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, double score, string classId, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Score = score;
            ClassId = classId;
            BirthDate = birthDate;
        }
    }
}