/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

string GetElement (int position) 
{
    int[,] numbers = new int [,] { { 1 ,4, 7 , 2}, {5, 9, 2, 3}, { 8, 4, 2, 4} };
    string result = "такого числа в массиве нет";
    position = position-1;
 
    if (position < numbers.GetLength(0) * numbers.GetLength(1))
    {

        int i = position/numbers.GetLength(1);
       // Console.WriteLine (i);
        int j = position % numbers.GetLength(1);
        //Console.WriteLine (j);
        result = Convert.ToString(numbers[i,j]);
        }
    return result;
    
}



Console.WriteLine("Введите позицию элемента в массиве п/п начиная с 1");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(GetElement(x));