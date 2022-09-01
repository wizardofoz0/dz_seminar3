/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double [,] GetArray (int m, int n)
{
    double[,] Num = new double [m, n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
       {
        Num[i,j] = Math.Round(new Random().Next(-10,10) + 
        new Random().NextDouble(),1);
       }
    }
    return Num;
}

void PrintArray (double [,] Numbers, int m, int n)
{
    for (int i = 0; i<m; i++)
    {
         Console.WriteLine(" ");
         for (int j = 0; j<n; j++)
                    {
                    Console.Write(Numbers[i,j]);
                    Console.Write("    ");
                    }
    }
}

Console.WriteLine("Введите размерность m двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность n двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());

double [,] a = GetArray(m,n);
PrintArray(a, m, n);