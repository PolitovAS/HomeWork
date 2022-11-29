/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число: ");
string numStr = Console.ReadLine() ?? "";
int num = Convert.ToInt32(numStr);

if (num % 2 == 0)
{
    Console.WriteLine($"{num} - четное");
}
else
{
    Console.WriteLine($"{num} - не четное");
}