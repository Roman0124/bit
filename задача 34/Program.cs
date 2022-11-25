// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
Random r = new Random ();
int x = 0;
for (int i = 0; i < arr.Length; i++)
{
 arr [i] = r.Next(100 , 1000);
 Console.Write($"{arr [i] } ");
if (arr [i] % 2 == 0)
{
x++;
}
}
Console.WriteLine();
Console.WriteLine($"количество чётных чисел в массиве={x}");
