//   Напиши программу, которая будет запрашивать у пользователя возраст.
// Если его возраст больше 18 - то выводим "Доступ разрешен"
// А если возраст меньше 18, то "Доступ запрещен"
// 29 -> доступ разрешен
Console.Write ("Введите а  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 18)
{
    Console.WriteLine("доступ разрешен");
}
else
{
    Console.WriteLine("доступ запрещен");
}

