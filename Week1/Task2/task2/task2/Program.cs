using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");

            string sName = Console.ReadLine(); //создаем переменную sName для ввода данных студента 
            Console.WriteLine("Write ID: ");
            string sId = Console.ReadLine();
            Console.WriteLine("Write year of study: ");
            int sYear; // создаем переменную для Year of study
            string num = Console.ReadLine(); // для того что бы пользователь не ввел буквы вместо цифр 
            bool res = false; //
            while (!res)
            {
                res = int.TryParse(num, out sYear);
                if (res) break;
                Console.WriteLine("Error: you must write number.");
                num = Console.ReadLine();
            }
            sYear = int.Parse(num);






            Class1 s = new Class1(sName, sId); // конструктор 
            s.data();

            s.NextYear();
            s.data();            Console.ReadKey();

        }
    }
}
        
    

