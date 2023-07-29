using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    internal class Program
    {
        public static void RunApp()
        {
            char ch;
            do
            {
                int choice;
                Console.WriteLine("Select\nElementry school\nMiddle School\nHigh School");
                choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       
                        Console.WriteLine("Enter marks in maths");
                        int m1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in English");
                        int m2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Social");
                        int m3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Science");
                        int m4 = int.Parse(Console.ReadLine());
                        ElementarySchoolGradeCard es = new ElementarySchoolGradeCard(m1, m2, m3, m4);
                        Console.WriteLine("Total Marks : "+es.GetTotal());
                        break;
                    case 2:
                        Console.WriteLine("Enter marks in maths");
                        int mat = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Physics");
                        int phy = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in chemistry");
                        int che = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Biology");
                        int bio = int.Parse(Console.ReadLine());
                        MiddleSchoolGradeCard ms = new MiddleSchoolGradeCard(mat, phy, che, bio);
                        Console.WriteLine("Total Marks : " + ms.GetTotal());
                        break;
                    case 3:
                        Console.WriteLine("Enter marks in maths");
                        int maths = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Physics");
                        int physics = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in chemistry");
                        int chemistry = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Biology");
                        int biology = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in English");
                        int eng = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in History");
                        int hist = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter marks in Geography");
                        int geo = int.Parse(Console.ReadLine());
                        HighSchoolGradeCard hs=new HighSchoolGradeCard(maths,eng,physics,chemistry,biology,hist,geo);
                        Console.WriteLine("Total Marks : " + hs.GetTotal());
                        break;
                    default:break;
                }
                Console.WriteLine("if you want to continue press y");
                ch = char.Parse(Console.ReadLine().ToLower());
            } while (ch == 'y');
        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();
        }
    }
}
