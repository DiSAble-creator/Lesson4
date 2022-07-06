using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введитре длину последовательности: ");
            int size = int.Parse(Console.ReadLine()); //Пользователь вводит длину массива

            int[] array = new int[size]; //Объявляем и инициализируем одномерный массив заданной пользователем длины

            int minValue = int.MaxValue; //Объявляем переменную в которой будет храниться минимальное значение массива. Присваиваем переменной максимальное значение типа int

            Console.WriteLine("Заполните последовательность целыми числами");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i+1}/{array.Length} - ");
                array[i] = int.Parse(Console.ReadLine()); // Полбзователь заполняет массив
            }

            foreach (int e in array)
            {
                if (e < minValue) minValue = e; //Находим минимальное число массива
            }
            Console.WriteLine($"Минимальное число в последовательности: {minValue}"); //Выводим минимальное число массива
            Console.ReadLine();
        }
    }
}
