/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] GetArray (int N)
{
    double[] Num = new double [N];
    for (int i = 0; i<N; i++)
    {
     Num[i] = new Random().Next(1,100);
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

double GetMax (double [] N)
{
    double max = N[1];
    for (int i = 0; i<N.Length; i++)
    {
      if (max < N[i]) 
      {
        max = N[i];
      }
    }
    return max;
}
double GetMin (double [] N)
{
    double min = N[1];
    for (int i = 0; i<N.Length; i++)
    {
      if (min > N[i]) 
      {
        min = N[i];
      }
    }
    return min;
}



Console.WriteLine("Введите размерность массива");
double [] a = GetArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(a);
Console.WriteLine(" ");
Console.WriteLine(GetMax(a)- GetMin(a));