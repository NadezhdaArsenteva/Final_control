// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод исходного массива строк с клавиатуры
            Console.WriteLine("Введите строки через запятую:");
            string input = Console.ReadLine();
            string[] initialArray = input.Split(',');

            // Создание нового массива для строк длиной <= 3 символа
            string[] resultArray = GetShortStringsArray(initialArray);

            // Вывод результирующего массива
            Console.WriteLine("Результирующий массив:");
            if (resultArray.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write($"\"{resultArray[i]}\"");
                    if (i < resultArray.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");
            }

            Console.ReadLine();
        }

        static string[] GetShortStringsArray(string[] inputArray)
        {
            // Подсчитываем количество строк длиной <= 3 символа
            int shortStringsCount = 0;
            foreach (string str in inputArray)
            {
                if (str.Length <= 3)
                {
                    shortStringsCount++;
                }
            }

            // Создаем новый массив нужной длины
            string[] resultArray = new string[shortStringsCount];

            // Заполняем новый массив строками длиной <= 3 символа
            int index = 0;
            foreach (string str in inputArray)
            {
                if (str.Length <= 3)
                {
                    resultArray[index] = str;
                    index++;
                }
            }

            return resultArray;
        }
    }
}