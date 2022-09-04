/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int[,] MultiplayMatrix(int[,] array1, int[,] array2)

{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int Multiplay = 0;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
            Multiplay = array1[i,k] * array2 [k,j];
            result [i,j] += Multiplay;
            }
        }
    }
    return result;
}

void PrintArray (int [,] Numbers)
{
    for (int i = 0; i< Numbers.GetLength(0); i++)
    {
         Console.WriteLine(" ");
         for (int j = 0; j<Numbers.GetLength(1); j++)
                    {
                    Console.Write(Numbers[i,j]);
                    Console.Write("    ");
                    }
    }
}

int[,] matrixOne = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrixTwo = new int[,] { { 3, 4 }, { 3, 3 } };
PrintArray(MultiplayMatrix(matrixOne,matrixTwo));