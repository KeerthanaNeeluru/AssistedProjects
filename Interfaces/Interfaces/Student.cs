using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Student : IPerson
    {
        int age;
        string name,address;
        public int Age
        {
            get { return age; } set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; } set { address = value; }
        }

        public string GetInfo()
        {
            string info = "Name : " + name + "Age" + age +", Address : " + address + "\n ";
            return info;
        }

        public string GetTypeOfPerson()
        {
            return "Student";
        }
    }
}
