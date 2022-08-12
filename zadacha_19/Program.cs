/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

string IsPalindrom(int number)
{
    string answer = "-1";
    if ((number > 99999)|(number < 10000))
    {
        return answer;
    }
    int res1 = number/1000-(number/10000)*10;
    int res2 = (number%100 - number%10)/10;
    if ((number%10 == number/10000)&(res1== res2))
    {
        answer = "да";
    }
    else 
    {
        answer = "нет"; 
    }
    
    return answer;
}

Console.WriteLine ("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string answer = IsPalindrom (number);
Console.WriteLine ($"Число {number} - палиндром? - {answer}");