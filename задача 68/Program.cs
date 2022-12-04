// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int akker (int M , int N)
{
    if (M == 0 )
        return N + 1;
    else if (M > 0 & N == 0)
        return akker (M - 1 , 1);

    else 
        return akker (M - 1 , akker (M, N - 1));
}
Console.WriteLine ("введите число M");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("введите число N");
int N = Convert.ToInt32 (Console.ReadLine());
int A =  akker (M , N);
Console.WriteLine ($"{A}");