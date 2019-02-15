using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Line (int line)
        {
            for (int i = 0; i < line; i++)
            {
                Console.WriteLine("     ");
            }
        }
        static void File(DirectoryInfo dir, int line)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                Line(line);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Line(line);
                Console.WriteLine(d.Name);
                File(d, line + 1);

            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\tempo");
            File(dir, 0);
            Console.ReadKey();
        }
    }
}
