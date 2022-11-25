// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("input a");
int a = Convert.ToInt32(Console.ReadLine());
int Rezalt = 0;
while (a > 0)
{
    Rezalt += a % 10;
    a = a / 10;
}
Console.WriteLine (Rezalt);
