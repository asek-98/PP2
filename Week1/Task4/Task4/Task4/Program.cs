using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int i, j;
            int[,] arr = new int[n, n]; // create 2d array
            for (i = 0; i < n; i++) //create star triangle
            {
                for (j = 0; j <= i; j++) // shouldn`t be no more than i
                {
                    Console.WriteLine("[*]");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
                    Console.ReadKey();
                }
            }
}
