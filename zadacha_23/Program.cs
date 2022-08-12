/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
double [] GetCubeNumbers (int N)
{
    double [] numbers = new double [N];
    double k = 0;
    for (int i = 0; i < N; i++)
    {
        k = Convert.ToDouble(i) + 1;
        numbers[i] = Math.Pow(k,3);
    }
       return numbers;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
double [] numbers = GetCubeNumbers (number);
for (int i = 0; i < number; i++)
{
    Console.WriteLine (numbers[i]);
}