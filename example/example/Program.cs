using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the number to check Prime:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(i = 2; i <= m; i++)
            {
                if(n % i == 0)
                {
                    Console.Write("Number is not prime.");
                    flag = 1;
                    break;
                }
            }

            if(flag != 1)
            {
                Console.WriteLine("Number is prime");
            }
        }

    }
}
