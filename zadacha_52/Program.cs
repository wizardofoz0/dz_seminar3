/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


double [] GetMean (int [,] array) 
{
    double[] Num = new double [array.GetLength(0)];
    for (int i = 0; i<array.GetLength(0); i++)
    {
        double S = 0;
      
       for (int j = 0; j<array.GetLength(1); j++)
       {
        S = S + array[i,j];
        //Console.WriteLine($"i={i}");
        //Console.WriteLine($"j={i}");
        //Console.WriteLine($"array[j,i]={array[i,j]}");
        //Console.WriteLine($"S={S}");
      
        Num [i] = System.Math.Round (S/array.GetLength(1), 1, MidpointRounding.ToZero);
      }
       
    }
    return Num;
}

 int[,] numbers = new int [,] { { 1, 5, 8}, { 4, 9, 4 }, { 7, 2, 2 }, { 2, 3, 4 } };

double [] result = GetMean(numbers);

for (int i = 0; i< result.Length; i++)
{Console.Write($"{result[i]}, ");}