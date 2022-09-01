/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int [] GetArray (int M)
{
    int [] n = new int [M];
    for (int i = 0; i < M; i++)
        {
            Console.WriteLine("Введите элемент массива");
            n [i] = Convert.ToInt32(Console.ReadLine());
        }
    return n;
}

int GetBiggerThanZeroCount (int [] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array [i] > 0)
            {
            cnt++;
            }
        }
    return cnt;
}

Console.WriteLine("Задайте размерность массива");
Console.WriteLine($" чисел больше нуля:  {GetBiggerThanZeroCount(GetArray(Convert.ToInt32(Console.ReadLine())))}");