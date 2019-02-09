using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, r = ""; // declare string 
          
            s = Console.ReadLine(); // reads string we enter
            for (int i = s.Length - 1; i >= 0; i--) //string reverse
            {
                r += s[i].ToString(); // reversed string we save in the r
            }
            if (r == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("Yes", s); // if it is palindrome then console shows yes
            }
            else
            {
                Console.WriteLine("No", s); // otherwise No
            }
            Console.ReadKey();

        }
    }
}
