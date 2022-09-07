/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNaturalSum (int start, int end, int Sum)
{
     int i = end;
     int S = Sum;
    if (i >= start)
     {   
        //S = S + end;
        return GetNaturalSum(start, end-1, S+end);
    }
  return S;
}
int M = 1;
int N = 15;
Console.WriteLine(GetNaturalSum(M, N, 0));