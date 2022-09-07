/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.

M = 1; N = 5. -> ""5,4,3,2,1""

M = 4; N = 8. -> ""8,7,6,5,4""*/

void PrintNaturalNumbers (int start, int end)
{
     int i = end;
    if (i >= start)
     {   
        Console.Write($"{i}, ");
        PrintNaturalNumbers(start,end-1);
    }
}
int M = 1;
int N = 5;
PrintNaturalNumbers(M, N);
