/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

double MyPow(int A, int B)
{
    double result = 1;
    for (int i=0; i < B; i++)
    {
     result = result * A;
    }
    return result;

}

Console.WriteLine ("Введите число A");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число B");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (MyPow(x,y));