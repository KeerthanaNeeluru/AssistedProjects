using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class OfficeStaff
    {
        int age;
        public int Age { get { return age; } set { age = value; } }
        string name, address;
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }

        public string GetInfo()
        {
            string info = "Name : " + name + "Age" + age + ", Address : " + address + "\n ";
            return info;
        }

        public string GetTypeOfPerson()
        {
            return "Office Staff";
        }
    }
}
