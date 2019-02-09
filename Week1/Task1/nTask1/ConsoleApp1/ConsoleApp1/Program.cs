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
        List<string> list = new List<string>(); //создаем динамический массив 
        int n = int.Parse(Console.ReadLine()); // читаем сколько чисел надо ввести 

        string[] arr = Console.ReadLine().Split(); //заполняем массив 
        foreach (string s in arr) //для каждого элемента этого массива 
            { 
                int sum = 0; // создаем переменную sum, для того чтобы узнать колтчество простых чисел.
                for (int i = 2; i <= arr.Length; i++) // пробегаемся циклом for по всем числам 
                { 
            if (int.Parse(s) % i == 0) // проверяем делится ли без остатка 
            { 
            sum += 1; // если да то прибавляем один, каждый раз пока наше число простое
            }
               } 
        if (sum == 1)
                { 
        list.Add(s); // если число простое то добавляем в динамический массив 
                }
            } 
        Console.WriteLine(list.Count); //выводим сколько чисел есть в массиве 
        foreach(string s in list) 
        { 
        Console.Write(s + " "); // выводим ответ в консоль
                Console.ReadKey(); // данный тип консоль нужен для того чтобы окно не закрывалась автоматически.
            } 

        } 

    } 

}