// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив для примера
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.Write("Введите индекс строки: ");
        int rowIndex = int.Parse(Console.ReadLine());

        Console.Write("Введите индекс столбца: ");
        int columnIndex = int.Parse(Console.ReadLine());

        int rowCount = array.GetLength(0); // Количество строк в массиве
        int columnCount = array.GetLength(1); // Количество столбцов в массиве

        if (rowIndex >= 0 && rowIndex < rowCount && columnIndex >= 0 && columnIndex < columnCount)
        {
            int element = array[rowIndex, columnIndex];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Указанный элемент не существует.");
        }
    }
}
