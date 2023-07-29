using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Student
    {
        public string Name;
        public int Age;
        public int RollNo;
        public string Branch;
    }
    internal class Program
    {
        public static void DoApp()
        {
            Student[] students=new Student[100];
            int count = 0;
            char ch;
            do
            {
                Console.WriteLine("Select\n1.Add Student\n2.Display all Students");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Student's Name : ");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter Srudent's age");
                        int age=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Srudent's RollNo");
                        int rno=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Srudent's Branch");
                        string branch=Console.ReadLine();
                        Student stu = new Student { Name = name, Age = age, RollNo = rno, Branch = branch };
                        students[count] = stu;
                        count++;
                        break;
                    case 2:
                        Console.WriteLine("Students Details:");
                        for(int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"Name : {students[i].Name}\nAge :  {students[i].Age}\nRollNo :  {students[i].RollNo}\nBranch :  {students[i].Branch}\n\n\n");

                        }
                        break;
                    default:break;
                }
                Console.WriteLine("If you want to continue press y");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'y');
        }
        static void Main(string[] args)
        {
            DoApp();
            Console.ReadKey();
        }
    }
}
