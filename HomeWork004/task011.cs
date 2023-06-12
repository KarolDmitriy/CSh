// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число B:");
        int b = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }

        Console.WriteLine($"{a} в степени {b} равно {result}");
    }
}
