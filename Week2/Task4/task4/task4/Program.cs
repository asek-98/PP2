using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\tempo\demo.txt"); // чтени и запись текстовых файлов
            writer.Write("PP2 one love"); // записываем текст в текстовый файл, при этом уже указав файл
            writer.Close(); // закрывает файл
            File.Copy(@"C:\tempo\demo.txt", @"C:\tempo\demo2.txt"); // дублирует файл
            // File.Delete(@"C:\tempo\demo.txt"); // удаляем нужный файл
            Console.ReadKey();// необходим для того чтобы консоль не закрывалась автоматически.
        }
    }
}
