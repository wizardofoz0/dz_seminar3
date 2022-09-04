/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int GetSum(int[] row)
{
    int S = 0;
    for (int i = 0; i < row.Length; i++)
    {
        S += row[i];
        //Console.WriteLine($"S= {S}");
    }
    return S;
}

int GetMin(int[] array)
{
    int min = array[0];
    int minIndex = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i+1;

        }
     //   Console.WriteLine($"min = {min}");
     //   Console.WriteLine($"minIndex = {minIndex}");
    }
    return minIndex;
}

int ReturnRowMinSum(int[,] num)
{
    int[] row = new int[num.GetLength(0)];
    int[] Sum = new int[num.GetLength(0)];
    for (int i = 0; i < num.GetLength(0); i++)
    {

        for (int j = 0; j < num.GetLength(1); j++)
        {
            row[j] = num[i, j];
        }
        Sum[i] = GetSum(row);
    }
    int result = GetMin(Sum);
    return result;
}

int[,] numbers = new int[,] { { 1, 4 , 7,  2 }, {5, 9 , 2, 3 }, { 8, 4, 2, 4}, { 5, 2, 6, 7 } };
//int[,] numbers = new int[,] { { 1, 2, 3 }, { 1, 8, 1 }, { 3, 3, 3 }, { 1, 1, 1 } };
Console.WriteLine($"{ReturnRowMinSum(numbers)} строка");
