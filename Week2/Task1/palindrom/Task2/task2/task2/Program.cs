
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static bool prime(int n)
        {
            if (n == 1 || n == 0) return false;
            for(int i = 2; i < n/2; i++)
            {
                if (n % i == 0) return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\tempo\demo.txt");
            StreamWriter writer = new StreamWriter(@"C:\tempo\demo2.txt");
            string n = reader.ReadLine();
            string[] a = n.Split(' ');
            foreach (string s in a)
            {
                if (prime(int.Parse(s)))
                    writer.Write(s + " ");
            }
            reader.Close();
            writer.Close();
           
           // Console.ReadLine();

            //string filePath = @"C:\tempo\demo.txt";
            //Console.ReadLine();
            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //    foreach(string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Add("Sabina Baigudeeva 188181");
            //File.WriteAllLines(filePath, lines);
            //Console.ReadLine();
        }

    }
}
