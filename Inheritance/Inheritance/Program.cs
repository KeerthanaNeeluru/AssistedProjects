using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class CClass
    {
        public string ClassName { get; set; }
        public ClassTeacher ClassTeacher { get; set; }
        public SubjectTeacher[] SubjectTeachers { get; set; }
    }

    class ClassTeacher : Teacher
    {
        public string ClassRole { get; set; }
    }

    class SubjectTeacher : Teacher
    {
        public string Subject { get; set; }
    }

    internal class Program
    {
        static void runApp()
        {
            // Create Teachers
            Teacher mathTeacher = new Teacher { Name = "John Doe", Age = 35 };
            Teacher scienceTeacher = new Teacher { Name = "Jane Smith", Age = 28 };

            // Create Class Teacher
            ClassTeacher classTeacher = new ClassTeacher { Name = "John Doe", Age = 35, ClassRole = "Math Teacher" };

            // Create Subject Teachers
            SubjectTeacher subjectTeacher1 = new SubjectTeacher { Name = "John Doe", Age = 35, Subject = "Mathematics" };
            SubjectTeacher subjectTeacher2 = new SubjectTeacher { Name = "Jane Smith", Age = 28, Subject = "Science" };

            // Create CClass and populate with class teacher and subject teachers
            CClass cClass = new CClass
            {
                ClassName = "Class 10",
                ClassTeacher = classTeacher,
                SubjectTeachers = new SubjectTeacher[] { subjectTeacher1, subjectTeacher2 }
            };

            // Display Class Information
            Console.WriteLine($"Class Name: {cClass.ClassName}");

            Console.WriteLine("\nClass Teacher:");
            Console.WriteLine($"Name: {cClass.ClassTeacher.Name}, Age: {cClass.ClassTeacher.Age}, Role: {cClass.ClassTeacher.ClassRole}");

            Console.WriteLine("\nSubject Teachers:");
            foreach (var subjectTeacher in cClass.SubjectTeachers)
            {
                Console.WriteLine($"Name: {subjectTeacher.Name}, Age: {subjectTeacher.Age}, Subject: {subjectTeacher.Subject}");
            }
        }
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
    }
}
