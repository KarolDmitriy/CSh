// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вещественные числа, разделенные пробелами:");
        string input = Console.ReadLine();

        // Разбиваем строку на отдельные числа
        string[] numbers = input.Split(' ');

        // Создаем массив и заполняем его числами
        double[] array = new double[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = double.Parse(numbers[i]);
        }

        // Находим максимальный и минимальный элементы массива
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

        // Вычисляем разницу между максимальным и минимальным элементами
        double difference = max - min;

        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Минимальный элемент: {min}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}
