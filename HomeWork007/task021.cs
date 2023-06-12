// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив
        int[,] array = {
            { 5, 2, 8 },
            { 3, 2, 5 },
            { 2, 1, 8 }
        };

        int rows = array.GetLength(0); // Количество строк
        int cols = array.GetLength(1); // Количество столбцов

        // Создаем массив для хранения сумм значений каждого столбца
        int[] columnSums = new int[cols];

        // Вычисляем сумму значений для каждого столбца
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                columnSums[j] += array[i, j];
            }
        }

        // Выводим результаты
        Console.WriteLine("Сумма значений для каждого столбца:");

        for (int j = 0; j < cols; j++)
        {
            // Вычисляем среднее значение и округляем до десятых
            double average = Math.Round((double)columnSums[j] / rows, 1);
            Console.WriteLine($"Столбец {j + 1}: {average}");
        }
    }
}
