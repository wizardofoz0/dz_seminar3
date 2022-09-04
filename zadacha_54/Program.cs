/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void OrderStringArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {  
        int minPositionI = i;
        for (int k =  0; k < array.GetLength(1)-1; k++)
         {
        int minPositionJ = k;
        for (int j =  k+1; j < array.GetLength(1); j++)
        {   
            if(array[i,j] < array[minPositionI,minPositionJ]) 
            {
                minPositionI = i;
                minPositionJ = j;
              
                }
             int temporary = array[i, j];
             array[i, j] = array[minPositionI, minPositionJ];
             array[minPositionI,minPositionJ] = temporary;
        }
       
         }
     }
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


 int[,] numbers = new int [,] { { 1 ,4, 7 , 2}, {5, 9, 2, 3}, { 8, 4, 2, 4} };
 OrderStringArray(numbers);
 PrintArray(numbers);