/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double GetLength(int ax, int ay, int az, int bx, int by, int bz)
{
    int cx = ax - bx;
    int cy = ay - by;
    int cz = az - bz;

    double length = Math.Round(Math.Sqrt(Math.Pow(cx,2) + Math.Pow(cy,2) + Math.Pow(cz,2)),2);
    return length;
}

Console.WriteLine("Введите координаты точки А: X");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А: Y");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А: Z");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: X");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: Y");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: Z");
int bz = Convert.ToInt32(Console.ReadLine());

double result = GetLength(ax, ay, az, bx, by, bz);
Console.WriteLine(result);