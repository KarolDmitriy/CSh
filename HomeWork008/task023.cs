// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 0, 0, 0 },
            { 4, 5, 6 },
            { 2, 1, 1 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSumRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1));
    }
}
