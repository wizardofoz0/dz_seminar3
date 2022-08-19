/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

double[] GetArray (int N)
{
    double[] Num = new double [N];
    for (int i = 0; i<N; i++)
    {
     Num[i] = new Random().Next(-100,100);
    }
    return Num;
}


void PrintArray (double [] Numbers)
{
    for (int i = 0; i<Numbers.Length; i++)
    {
     Console.Write(Numbers[i]);
     Console.Write(", ");
    }
}

double GetSumOdd (double [] N)
{
    double S = 0;
    for (int i = 0; i<N.Length; i=i+2)
    {
     S = S + N[i];
    }
    return S;
}



Console.WriteLine("Введите размерность массива");
double [] a = GetArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(a);
Console.WriteLine(" ");
Console.WriteLine(GetSumOdd(a));