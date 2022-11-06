//  Вводим с клавиатуры размер 3 сторон треугольника.
//   И говорим какой он - обычный, равнобедренный или равносторонний
//   a = 6
//   b = 8
//   c = 6
Console.Write("Введите а");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c)
Console.Write ("обычный");
if (a + c > b)
Console.Write ("равнобедренный");
if (b + c > a)
Console.Write ("равносторонний");

