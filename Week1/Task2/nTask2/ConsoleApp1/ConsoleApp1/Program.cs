using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // input number 

            int[] a = new int[n]; // create array 

            int cnt = 0; // counter=0 

            for (int i = 0; i < n; i++) // input numbers into array 
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++) // output every number two times 
            {
                Console.Write(a[i]);
                Console.Write(a[i]);
            }
        }
    }
}
