using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Class1
    {
        string name; // переменные класса 
        string id;
        public int yearofStudy;

        public Class1(string n, string i) // конструктор с 2 параметрами 
        {
            name = n;
            id = i;
        }
        public void data() // метод который выводит данные студента
        {
            Console.WriteLine("Name of student: " + name + "\n" + "ID of student: " + id);
        }
        public int NextYear(int y) // метод который изменяет курс обучение студента на +1 
        {
            yearofStudy = y;
            return yearofStudy + 1;
        }
    }
}