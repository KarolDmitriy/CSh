// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива m × n
        int m = 4;
        int n = 3;

        // Создаем двумерный массив
        double[,] array = new double[m, n];

        // Создаем генератор случайных чисел
        Random random = new Random();

        // Заполняем массив случайными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Генерируем случайное число от -10 до 10
                double randomNumber = random.NextDouble() * 20 - 10;

                // Округляем число до одного знака после запятой
                double roundedNumber = Math.Round(randomNumber, 1);

                // Записываем число в массив
                array[i, j] = roundedNumber;
            }
        }

        // Выводим массив на консоль
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
