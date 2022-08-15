/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120*/

using static System.Console;
Clear();
WriteLine("Введите число");

WriteLine(FunctionMultiply (Convert.ToInt32(ReadLine())));

int FunctionMultiply(int n)
{
    int result = 1;

for (int i=1; i<=n; i++)
{
result*=i;
}

    return result;
}
