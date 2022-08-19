/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

double[] GetArray (int N)
{
    double[] Num = new double [N];
    for (int i = 0; i<N; i++)
    {
     Num[i] = new Random().Next(100,1000);
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

int GetOdd (double [] N)
{
    int S = 0;
    for (int i = 0; i<N.Length; i++)
    {
    if (N[i]%2 == 0) 
    {
        S = S + 1;
    }

    }
    return S;
}



Console.WriteLine("Введите размерность массива");
double [] a = GetArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(a);
Console.WriteLine(" ");
Console.WriteLine(GetOdd(a));