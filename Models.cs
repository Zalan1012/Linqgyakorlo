using System;
using System.Collections.Generic;

namespace LinqGyakorlo
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";

        public override string ToString() => $"{Name} ({Department})";
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Credit { get; set; }
        public int TeacherId { get; set; }
        public string Category { get; set; } = "";

        public override string ToString() => $"{Name} [{Category}, {Credit} kredit]";
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string City { get; set; } = "";
        public string Gender { get; set; } = "";
        public double GradeAverage { get; set; }

        public override string ToString() => $"{Name} ({Age}, {City}, átlag: {GradeAverage:0.00})";
    }

    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; } // 1-5

        public override string ToString() => $"StudentId={StudentId}, CourseId={CourseId}, Grade={Grade}";
    }

    public static class SampleData
    {
        public static List<Teacher> Teachers = new()
        {
            new Teacher { Id = 1, Name = "Kovács Béla",   Department = "Matematika" },
            new Teacher { Id = 2, Name = "Nagy Éva",      Department = "Informatika" },
            new Teacher { Id = 3, Name = "Szabó Gábor",   Department = "Fizika" },
            new Teacher { Id = 4, Name = "Tóth Ilona",    Department = "Informatika" },
        };

        public static List<Course> Courses = new()
        {
            new Course { Id = 1, Name = "Programozás alapjai", Credit = 6, TeacherId = 2, Category = "Informatika" },
            new Course { Id = 2, Name = "Adatbázisok",         Credit = 5, TeacherId = 4, Category = "Informatika" },
            new Course { Id = 3, Name = "Lineáris algebra",    Credit = 4, TeacherId = 1, Category = "Matematika" },
            new Course { Id = 4, Name = "Analízis",            Credit = 5, TeacherId = 1, Category = "Matematika" },
            new Course { Id = 5, Name = "Mechanika",           Credit = 4, TeacherId = 3, Category = "Fizika" },
            new Course { Id = 6, Name = "Webfejlesztés",       Credit = 5, TeacherId = 2, Category = "Informatika" },
        };

        public static List<Student> Students = new()
        {
            new Student { Id = 1,  Name = "Kiss Anna",      Age = 20, City = "Budapest",  Gender = "N", GradeAverage = 4.50 },
            new Student { Id = 2,  Name = "Varga Bence",    Age = 22, City = "Debrecen",  Gender = "F", GradeAverage = 3.20 },
            new Student { Id = 3,  Name = "Horváth Csilla", Age = 21, City = "Szeged",    Gender = "N", GradeAverage = 4.80 },
            new Student { Id = 4,  Name = "Németh Dávid",   Age = 23, City = "Budapest",  Gender = "F", GradeAverage = 2.90 },
            new Student { Id = 5,  Name = "Molnár Eszter",  Age = 19, City = "Pécs",      Gender = "N", GradeAverage = 3.95 },
            new Student { Id = 6,  Name = "Farkas Ferenc",  Age = 24, City = "Debrecen",  Gender = "F", GradeAverage = 3.60 },
            new Student { Id = 7,  Name = "Balogh Gréta",   Age = 20, City = "Győr",      Gender = "N", GradeAverage = 4.10 },
            new Student { Id = 8,  Name = "Papp Hunor",     Age = 22, City = "Budapest",  Gender = "F", GradeAverage = 2.50 },
            new Student { Id = 9,  Name = "Takács Ibolya",  Age = 21, City = "Szeged",    Gender = "N", GradeAverage = 4.35 },
            new Student { Id = 10, Name = "Juhász János",   Age = 25, City = "Pécs",      Gender = "F", GradeAverage = 3.10 },
            new Student { Id = 11, Name = "Lakatos Kata",   Age = 19, City = "Budapest",  Gender = "N", GradeAverage = 4.95 },
            new Student { Id = 12, Name = "Oláh László",    Age = 23, City = "Győr",      Gender = "F", GradeAverage = 3.40 },
        };

        public static List<Enrollment> Enrollments = new()
        {
            new Enrollment { StudentId = 1,  CourseId = 1, Grade = 5 },
            new Enrollment { StudentId = 1,  CourseId = 2, Grade = 4 },
            new Enrollment { StudentId = 1,  CourseId = 6, Grade = 5 },
            new Enrollment { StudentId = 2,  CourseId = 3, Grade = 3 },
            new Enrollment { StudentId = 2,  CourseId = 4, Grade = 3 },
            new Enrollment { StudentId = 3,  CourseId = 1, Grade = 5 },
            new Enrollment { StudentId = 3,  CourseId = 2, Grade = 5 },
            new Enrollment { StudentId = 3,  CourseId = 6, Grade = 4 },
            new Enrollment { StudentId = 4,  CourseId = 5, Grade = 2 },
            new Enrollment { StudentId = 4,  CourseId = 3, Grade = 3 },
            new Enrollment { StudentId = 5,  CourseId = 1, Grade = 4 },
            new Enrollment { StudentId = 5,  CourseId = 6, Grade = 4 },
            new Enrollment { StudentId = 6,  CourseId = 4, Grade = 3 },
            new Enrollment { StudentId = 6,  CourseId = 5, Grade = 4 },
            new Enrollment { StudentId = 7,  CourseId = 2, Grade = 4 },
            new Enrollment { StudentId = 7,  CourseId = 1, Grade = 4 },
            new Enrollment { StudentId = 8,  CourseId = 3, Grade = 2 },
            new Enrollment { StudentId = 9,  CourseId = 1, Grade = 5 },
            new Enrollment { StudentId = 9,  CourseId = 2, Grade = 4 },
            new Enrollment { StudentId = 10, CourseId = 5, Grade = 3 },
            new Enrollment { StudentId = 11, CourseId = 1, Grade = 5 },
            new Enrollment { StudentId = 11, CourseId = 6, Grade = 5 },
            new Enrollment { StudentId = 11, CourseId = 2, Grade = 5 },
            new Enrollment { StudentId = 12, CourseId = 4, Grade = 3 },
            // Note: student Id 12 (Oláh László) has no enrollment in Course 5 -> hasznos "hiányzó" adat pl. GroupJoin-hoz
        };
    }
}
