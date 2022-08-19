/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int[] GetArray (int N)
{
    int[] Num = new int[N];
    for (int i = 0; i<N; i++)
    {
     Num[i] = new Random().Next(1,100);
    }
    return Num;
}


void PrintArray (int [] Numbers)
{
    for (int i = 0; i<Numbers.Length; i++)
    {
     Console.Write(Numbers[i]);
     Console.Write(", ");
    }
}

Console.WriteLine("Введите размерность массива");
PrintArray(GetArray(Convert.ToInt32(Console.ReadLine())));