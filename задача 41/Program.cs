// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.WriteLine("введите размер массива ");
int m = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[m];

int x = 0;
for (int i = 0; i < arr.Length; i++)
{
 arr [i] = Convert.ToInt32(Console.ReadLine());

if (arr [i] > 0)
{
x++;
}
}
for (int i = 0; i < arr.Length; i++)
 Console.Write($"{arr [i] } ");
Console.WriteLine();
Console.WriteLine($"количество чисел больше 0 = {x}");
