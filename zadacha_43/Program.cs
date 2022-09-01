/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double [] GetCrossPoint (double b1, double k1, double b2, double k2)
{
    double [] point = new double [2];
    point [0]  = (b2-b1)/(k1-k2);
    point [1] = k1 * (b2-b1)/(k1-k2) + b1;
    return  point;
}

Console.WriteLine("Задайте значение для 1 прямой b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение для 1 прямой k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте значение для 2 прямой b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение для 2 прямой k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double [] p = GetCrossPoint(b1, k1, b2, k2);
Console.WriteLine($" ({p[0]} , {p[1]} )");