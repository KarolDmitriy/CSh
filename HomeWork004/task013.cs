// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];

        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 101);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        SortByAbsoluteValue(numbers);

        Console.WriteLine("Отсортированный по модулю массив:");
        PrintArray(numbers);
    }

    static void SortByAbsoluteValue(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (Math.Abs(array[j]) < Math.Abs(array[i]))
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
