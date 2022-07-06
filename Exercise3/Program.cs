using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное целое число диапазона: ");
            int maxValue = int.Parse(Console.ReadLine()); // Пользователь вводит макисмальное значение диапазона
            Random r = new Random();
            int findNumber = r.Next(maxValue + 1);//Объявляем переменную и присваиваем случайное значение в диапазоне от 0 до введенного пользователем
            int userNumber; // Переменная в которой храниться введенное пользователем число
            string input; //Переменная в которой храниться введеный пользователем текст
            int tryCount = 0; //Количество попыток
            while (true)
            {
                Console.Write("Введите предпологаемое число: ");
                input = Console.ReadLine();
                tryCount++; //Прибавляем 1 попытку
                if (input == "") //Если пользовател ввел пустую строку, то выводим искомое число и выходим из цикла
                {
                    Console.WriteLine($"Загаданное число: {findNumber} ");
                    break;
                }
                    
                userNumber = int.Parse(input);
                if (userNumber == findNumber)
                {
                    Console.WriteLine($"Вы угадали загаданное число {findNumber} с {tryCount} попытки");
                    break;
                }
                else if (userNumber > findNumber)
                {
                    Console.WriteLine("Ваше число БОЛЬШЕ загаданного");
                }
                else if (userNumber < findNumber)
                {
                    Console.WriteLine("Ваше число МЕНЬШЕ загаданного");
                }
                
            }
            Console.ReadLine();
        }
    }
}
