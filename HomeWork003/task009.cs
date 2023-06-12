// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки (в формате x,y,z):");
        string point1Input = Console.ReadLine();

        Console.WriteLine("Введите координаты второй точки (в формате x,y,z):");
        string point2Input = Console.ReadLine();

        double distance = CalculateDistance(point1Input, point2Input);

        Console.WriteLine($"Расстояние между точками: {distance:F2}");
    }

    static double CalculateDistance(string point1Input, string point2Input)
    {
        string[] point1Coordinates = point1Input.Split(',');
        string[] point2Coordinates = point2Input.Split(',');

        double x1 = double.Parse(point1Coordinates[0]);
        double y1 = double.Parse(point1Coordinates[1]);
        double z1 = double.Parse(point1Coordinates[2]);

        double x2 = double.Parse(point2Coordinates[0]);
        double y2 = double.Parse(point2Coordinates[1]);
        double z2 = double.Parse(point2Coordinates[2]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        return distance;
    }
}
