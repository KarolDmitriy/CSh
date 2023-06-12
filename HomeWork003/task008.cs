// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }

    static bool IsPalindrome(int number)
    {
        // Преобразуем число в строку
        string numberString = number.ToString();

        // Проверяем, является ли строка палиндромом
        int length = numberString.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
