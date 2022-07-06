using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в матрице: ");
            int line = int.Parse(Console.ReadLine()); // Пользователь вводит количестов строк
            Console.Write("Введите количество столбцов в матрице: ");
            int column = int.Parse(Console.ReadLine()); //Пользователь вводит количество столбцов

            int[,] matrix = new int[line, column]; //Создаем двумерный массив

            Random r = new Random(); 
            int sum = 0; // Переменная суммы всех элементов массива
            Console.WriteLine($"Матрица из {line} строк и {column} столбцов:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(100); //Заполняем матрицу случайными числами от 0 до 99
                    Console.Write($"{matrix[i,j],2} "); //Выводим элекмент матрицы
                    sum += matrix[i, j]; // Прибавляем к переменной суммы значение элемента матрицы
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы - {sum}"); // Выводим сумму всех элементов матрицы
            Console.ReadKey();
        }
    }
}
