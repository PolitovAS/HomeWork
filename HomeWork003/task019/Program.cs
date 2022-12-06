/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out int n))
{
    Console.WriteLine($"{str} не является числом");
}
else if (str.Length != 5)
    {
        Console.WriteLine($"{str} не является пятизначным числом");
    }
    else if ((str[0] == str[4]) && (str[1] == str [3]))
        {
            Console.WriteLine($"{str} является палиндромом");
        }
        else
        {
            Console.WriteLine($"{str} не является палиндромом");
        }
