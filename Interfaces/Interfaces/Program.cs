using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        public static void RunApp()
        {
            Teacher t=new Teacher();
            Student s = new Student();
            OfficeStaff os=new OfficeStaff();

            t.Name = "Jhon";
            t.Age = 31;
            t.Address = "ABC Colony";

            s.Name = "Eva";
            s.Age = 22;
            s.Address = "XYZ Colony";


            os.Name = "Alice";
            os.Age = 38;
            os.Address = "ABC street";

            Console.WriteLine(t.GetInfo()+"\n"+t.GetTypeOfPerson()+"\n");
            Console.WriteLine(s.GetInfo() + "\n" + s.GetTypeOfPerson() + "\n");
            Console.WriteLine(os.GetInfo() + "\n" + os.GetTypeOfPerson() + "\n");


        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();
        }
    }
}
