// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        // Задаем первоначальный массив строк
        string[] initialArray = { "Hello", "2", "world", ":-)" };
        // Вызываем метод для формирования нового массива
        string[] filteredArray = FilterArray(initialArray);

        // Вывод результата
        Console.WriteLine("[" + string.Join(", ", initialArray) + "] → [" + string.Join(", ", filteredArray) + "]");
    }

    static string[] FilterArray(string[] array)
    {
        // Считаем, сколько элементов удовлетворяют условию
        int count = 0;
        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив подходящего размера
        string[] result = new string[count];

        // Заполняем новый массив подходящими элементами
        int index = 0;
        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                result[index] = item;
                index++;
            }
        }

        return result;
    }
}