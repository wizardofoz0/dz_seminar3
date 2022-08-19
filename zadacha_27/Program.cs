/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

double GetSum (int Num)
{
    double Sum = 0;
    string A = Convert.ToString(Num);
     Console.WriteLine(A);
    for (int i = 0; i < A.Length; i++)
    {
        string Z = Convert.ToString(A[i]);
        Sum = Sum + Convert.ToDouble(Z);
    }
    return Sum;
}

Console.WriteLine("Введите число:");
int Nuu = Convert.ToInt32(Console.ReadLine());
double S = GetSum (Nuu);
Console.WriteLine($"Сумма цифр в числе {Nuu} = {S}");