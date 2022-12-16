/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Первый вариант
System.Console.WriteLine("Сколько чисел хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int [m];
Console.Clear();
    
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите элемент массива под индексом {i}:\t");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) count++;
}

Console.Write($"Колличество элементов > 0:\t{count}");


// Второй вариант
/*
Console.WriteLine("Введите числа через пробел: ");
string str = Console.ReadLine() ?? "";
int[] array = Array.ConvertAll(str.Split(), int.Parse);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) count++;
}

Console.WriteLine("Колличество элементов > 0:");
Console.WriteLine(count);
*/

