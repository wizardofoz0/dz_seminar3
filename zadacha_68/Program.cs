/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29*/

int AccermanFunction(int number, int argument)
    {
       int result = argument;
        if (number == 0)
        {return argument + 1;}

        if ((number > 0)&(argument ==0))
        {result = AccermanFunction(number - 1, 1);}

         if ((number > 0)&(argument > 0))
        {result = AccermanFunction(number - 1, AccermanFunction(number, argument-1));}
  return result;
    }

int m = 3;
int n = 2;
Console.WriteLine(AccermanFunction(m,n));