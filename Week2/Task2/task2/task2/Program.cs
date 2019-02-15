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
        static bool isPrime(int n) //пишем функцию для проверки простых чисел.
        {
            bool pr = true; 
            if (n < 2)
            {
                pr = false;
            }
            for (int i = 2; i * i <= n; i++) // i = 2, потому что при делении любого числа на 1 в остатке всегда ноль.
            {
                if (n % i == 0) // если число делится без остатков
                {
                    pr = false;
                }
            }
            return pr;
        }
        static void Main(string[] args)
        {
            StreamReader st = new StreamReader(@"C:\tempo\prime\prime.txt"); //открываем файл
            string[] s = st.ReadToEnd().Split();//читаем содержимое
            StreamWriter sw = new StreamWriter(@"C:\tempo\prime\prime2.txt");//указываем файл, куда нужно написать простые числа
            int[] arr = new int[s.Length]; //создаем новый массив для хранения простых чисел
            for (int i = 0; i < s.Length; i++) 
            {
                arr[i] = int.Parse(s[i]); //конвертируем массив в int

            }
            for (int i = 0; i < s.Length; i++) //пробегаемся по циклу чтобы вывести числа
            {
                if (isPrime(arr[i]) == true) //если функция правильная
                {
                    sw.Write(arr[i] + " "); //выводим простые числа в другом файле
                }
            }            sw.Close(); //закрываем файл

            Console.ReadKey(); // необходимо для того чтобы консоль не закрывалась автоматически
        }
    }
}