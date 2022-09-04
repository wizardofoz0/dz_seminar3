/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] GetSpiralArray2()
{
    int[,] spiral = new int[4, 4];
    int value = 1;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            spiral[i, j] = value;
            value++;
        }
        int f = 3;
        for (i = 1; i < 4; i++)
        {
            spiral[i, f] = value;
            value++;
        }
        int a = 3;
        int b;
        for (b = 2; b > -1; b--)
        {
            spiral[a, b] = value;
            value++;
        }
        int c;
        int q = 0;
        for (c = 2; c > 0; c--)
        {
            spiral[c, q] = value;
            value++;
        }
        int d;
        int w = 1;
        for (d = 1; d < 3; d++)
        {
            spiral[w, d] = value;
            value++;
        }
        int e;
        int t = 2;
        for (e = 2; e < 3; e++)
        {
            spiral[e, t] = value;
            value++;
        }
        e = 2;
        int z;
        for (z = 1; z > 0; z--)
        {
            spiral[e, z] = value;
            value++;
        }
    }
    return spiral;
}

string fmt = "00";
void PrintArray(int[,] Numbers)
{
    for (int i = 0; i < Numbers.GetLength(0); i++)
    {
        Console.WriteLine(" ");
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            //Console.Write(Numbers[i, j]);
            Console.Write((Numbers[i, j].ToString(fmt)));
            Console.Write("    ");
        }
    }
}

PrintArray(GetSpiralArray2());