﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int nams(int N , int M)
{
    if (N < M)
        return N + nams (N + 1 , M);
    else 
        return N;
}
Console.WriteLine ("введите число 1");
int N = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("введите число 2");
int M = Convert.ToInt32 (Console.ReadLine());
if (N > M)
(N , M) = (M , N);
int sum =  nams ( N , M);
Console.WriteLine ($"сумма чисел от {N} до  {M} равна {sum}");
