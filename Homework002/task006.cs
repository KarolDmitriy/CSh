// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string numberString = Console.ReadLine();

        int numberLength = numberString.Length;

        if (numberLength < 3)
        {
            Console.WriteLine("У числа нет третьей цифры.");
        }
        else if (numberLength > 3)
        {
            string trimmedNumberString = numberString.Substring(0, 3);
            int number = int.Parse(trimmedNumberString);
            int remainder = number % 10;
            Console.WriteLine($"Третья цифра: {remainder}");
        }
        else
        {
            int number = int.Parse(numberString);
            int remainder = number % 10;
            Console.WriteLine($"Третья цифра: {remainder}");
        }
    }
}
