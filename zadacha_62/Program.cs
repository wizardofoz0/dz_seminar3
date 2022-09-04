/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] GetSpiralArray()
{
    int[,] spiral = new int[4, 4];
    int value = 1;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            spiral[i, j] = value;
            value++;
            if (j == 3)
            {

                for (i = 1; i < 4; i++)
                {
                    spiral[i, j] = value;
                    value++;
                }
                if (i == 4)
                {
                    int a = 3;
                    int b;
                    for (b = 2; b > -1; b--)
                    {
                        spiral[a, b] = value;
                        value++;
                        if (b == 0)
                        {
                            int c;
                            for (c = 2; c > 0; c--)
                            {
                                spiral[c, b] = value;
                                value++;
                                if (c == 1)
                                {
                                    int d;
                                    for (d = 1; d < 3; d++)
                                    {
                                        spiral[c, d] = value;
                                        value++;
                                        if (d == 2)
                                        {
                                            d=2;
                                            int e;
                                            for (e = 1; e < 3; e++)
                                            {
                                                spiral[e, d] = value;
                                                value++;
                                            }
                                            if (e == 3)
                                            {
                                                e=2;
                                                int z;
                                                for (z = 1; z > 0; z--)
                                                {
                                                    spiral[e, z] = value;
                                                    value++;
                                                }
                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }

                }
            }
        }

    }
    return spiral;
}

/*
void FillImage(int row, int col)
{
 if (pic[row, col] == 0)
 {
 pic[row, col] = 1;
 FillImage(row - 1, col);
 FillImage(row, col - 1);
 FillImage(row + 1, col);
 FillImage(row, col + 1);
 }
}
*/
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

PrintArray(GetSpiralArray());