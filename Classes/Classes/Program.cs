using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int age { get; set; }
    }
    class Teachers
    {
        public int TId { get; set; }
        public string TName { get; set; }
        public string TDomain { get; set; }
    }
    class Subject
    {
        public int SId { get; set; }
        public string SubjectName { get; set; }
    }
    class CClass
    {
        public string Section { get; set; }
        public Subject[] subject { get; set; }
        public Teachers[] teachers { get; set; }
        public Students[] students { get; set; }
    }


    internal class Program
    {
        public static void RunApp()
        {
            Subject s1= new Subject {SId=01,SubjectName="Python" };
            Subject s2 = new Subject { SId = 02, SubjectName = "JAVA" };

            Teachers t1 = new Teachers {TId=101,TName="Jhon",TDomain="Python"  };
            Teachers t2 = new Teachers { TId = 102, TName = "Jane", TDomain = "JAVA" };

            Students stu1 = new Students {Id=1025,Name="Eva",age=23 };
            Students stu2 = new Students { Id = 1029, Name = "Alice", age = 22 };
            CClass c1 = new CClass
            {
                Section="CSE-A",
                subject=new Subject[] { s1, s2 },   
                teachers=new Teachers[] { t1, t2 },
                students=new Students[] { stu1, stu2 }
            };
            Console.WriteLine("Section : "+c1.Section);
            Console.WriteLine("\nSubjects :");
            foreach(var s in c1.subject)
            {
                Console.WriteLine($"SubjectId: {s.SId}\nSubjectName : {s.SubjectName}\n");
            }
            Console.WriteLine("Teachers details \n");
            foreach (var t in c1.teachers)
            {
                Console.WriteLine($"TeacherId : {t.TId}\nTeacherName : {t.TName}\nTeaching Domain : {t.TDomain}\n");
            }
            Console.WriteLine("Student Details\n");
            foreach (var s in c1.students)
            {
                Console.WriteLine($"StudentId : {s.Id}\nStudentName : {s.Name}\nStudentAge : {s.age}\n");
            }


        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();
        }
    }
}
