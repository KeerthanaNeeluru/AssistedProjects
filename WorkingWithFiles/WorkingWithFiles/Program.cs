using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class Program
    {
        public static void createfile(string filename, string path)
        {
            string fpath = path + filename;
            if (File.Exists(fpath))
            {
                Console.WriteLine("The file already exists");
            }
            else
            {
                File.Create(fpath);
                Console.WriteLine("File created");


            }
        }
        public static void readfile(string fname, string path)
        {
            string fpath = path + fname;
            /*StreamReader sr = new StreamReader(fpath);
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();*/
            if (File.Exists(fpath))
            {
                string[] lines = File.ReadAllLines(fpath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
        public static void RunApp()
        {
            string ch;
            do
            {

                int op;
                string fname, path;
                Console.WriteLine("Choose the operation you want to perform");
                Console.WriteLine("1.Create\n2.Read\n3.Append\n4.Delete");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Enter the filename");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter the path where you want file to be created");
                        path = Console.ReadLine();
                        createfile(fname, path);
                        break;
                    case 2:
                        Console.WriteLine("Enter the filename");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter the path where you file exists");
                        path = Console.ReadLine();
                        readfile(fname, path);
                        break;
                }
                Console.WriteLine("If you want to perform more operations enter y ");
                ch = Console.ReadLine().ToLower();
            } while (ch == "y");
        }


            static void Main(string[] args)
        {

        }
    }
}
