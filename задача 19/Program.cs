// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a; 
int c = 0;
while (a > 0)
{
    c = a % 10 + c * 10;
    a = a / 10; 
} 
Console.WriteLine (c);
if (b == c)
{
    Console.WriteLine ("ДА");
}
else 
{
   Console.WriteLine ("НЕТ");
}