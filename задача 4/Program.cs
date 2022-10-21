//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите а");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b & a>c)
Console.Write ("a max");
if (b>a & b>c)
Console.Write ("b max");
if (c>a & c>b)
Console.Write ("c max");
