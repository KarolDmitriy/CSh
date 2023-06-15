// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив
        int[,] array = {
            { 5, 8, 2, 1 },
            { 4, 9, 3, 7 },
            { 6, 2, 0, 5 }
        };

        // Упорядочиваем элементы каждой строки в порядке убывания
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            // Создаем временный массив для сортировки
            int[] temp = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                temp[j] = array[i, j];
            }

            // Сортируем временный массив в порядке убывания
            Array.Sort(temp);
            Array.Reverse(temp);

            // Копируем отсортированные элементы обратно в исходный массив
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = temp[j];
            }
        }

        // Выводим упорядоченный массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
