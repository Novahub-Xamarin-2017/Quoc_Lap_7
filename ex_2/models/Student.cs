﻿using System;

namespace EX_2.models
{
    public class Student : EasyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public int ClassId { get; set; }
        public DateTime BirthDate { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, double score, int classId, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Score = score;
            ClassId = classId;
            BirthDate = birthDate;
        }
    }
}