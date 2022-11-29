/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число: ");
string numfirst = Console.ReadLine() ?? "";

Console.WriteLine("Введите второе число: ");
string numsecond = Console.ReadLine() ?? "";

int nfirst = Convert.ToInt32(numfirst);
int nsecond = Convert.ToInt32(numsecond);

if (nfirst > nsecond)
{
    Console.WriteLine($"{nfirst} - большее, {nsecond} - меньшее");
}
else
{
    Console.WriteLine($"{nsecond} - большее, {nfirst} - меньшее");
}