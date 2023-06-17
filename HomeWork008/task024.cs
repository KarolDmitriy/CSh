// Напишите программу, которая заполнит спирально массив 4 на 4.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[4, 4]; // Создание массива 4x4

        int value = 1; // Начальное значение для заполнения
        int size = 4; // Размерность массива
        int row = 0; // Индекс текущей строки
        int col = 0; // Индекс текущего столбца
        int rowDirection = 0; // Направление движения по строкам (0 - вправо, 1 - вниз, 2 - влево, 3 - вверх)
        int colDirection = 1; // Направление движения по столбцам (0 - вправо, 1 - вниз, 2 - влево, 3 - вверх)

        while (value <= size * size)
        {
            matrix[row, col] = value;

            // Проверяем, нужно ли изменить направление движения
            if (col + colDirection >= size || row + rowDirection >= size || col + colDirection < 0 || matrix[row + rowDirection, col + colDirection] != 0)
            {
                // Изменяем направление движения по часовой стрелке
                int temp = rowDirection;
                rowDirection = colDirection;
                colDirection = -temp;
            }

            row += rowDirection; // Перемещаемся по строкам
            col += colDirection; // Перемещаемся по столбцам
            value++; // Увеличиваем значение для заполнения
        }

        // Выводим заполненный массив
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
