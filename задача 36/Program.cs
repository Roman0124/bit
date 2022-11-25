// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.WriteLine("введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
Random r = new Random ();
int x = 0;
for (int i = 0; i < arr.Length; i++)
{
 arr [i] = r.Next(0 , 1000);
 Console.Write($"{arr [i] } ");
if (i % 2 == 0)
{
x+=arr [i];
}
}
Console.WriteLine();
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях={x}");
