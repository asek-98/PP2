using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // input number 

            int[] a = new int[n]; // create array 
            
            for (int i = 0; i < n; i++) // input numbers into array 
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++) // output every number two times 
            {
                Console.Write(a[i] +" ");
                Console.Write(a[i]+" ");
                
            }
        }
    }
}