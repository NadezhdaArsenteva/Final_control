// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем исходный массив строк
        string[] inputArray = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

        // Вызываем метод для формирования нового массива
        string[] resultArray = GetNewArray(inputArray);

        // Выводим новый массив
        Console.WriteLine("Новый массив:");
        foreach (string str in resultArray)
        {
            Console.Write($"{str} ");
        }
        Console.ReadLine();
    }

    static string[] GetNewArray(string[] inputArray)
    {
        // Подсчитываем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] newArray = new string[count];
        int j = 0;

        // Копируем подходящие строки в новый массив
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[j] = str;
                j++;
            }
        }

        return newArray;
    }
}