// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine("введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
Random r = new Random ();
int max = int.MinValue;
int min = int.MaxValue;
for (int i = 0; i < arr.Length; i++)
{
 arr [i] = r.Next(0 , 1000);
 Console.Write($"{arr [i] } ");
if (max < arr [i])
max = arr [i];
if (min > arr [i])
min = arr [i];
}
Console.WriteLine();
Console.WriteLine($" разницф между максимальным {max} и минимальным {min} элементов массива ={max - min}");
