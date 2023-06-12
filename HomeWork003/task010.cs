// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до N:");
        Console.WriteLine("Число\tКуб");

        for (int i = 1; i <= n; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i}\t{cube}");
        }
    }
}
