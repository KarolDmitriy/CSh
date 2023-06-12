// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите цифру, обозначающую день недели (1-7):");
        int day = int.Parse(Console.ReadLine());

        bool isWeekend = IsWeekend(day);

        if (isWeekend)
        {
            Console.WriteLine("Этот день является выходным");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным");
        }
    }

    static bool IsWeekend(int day)
    {
        return day == 6 || day == 7;
    }
}
