/* Напишите программу,котоая выводит случайное число  из отрезка [10, 99] и показывает наибольшую цифру*/

Console.Clear();
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a1)
    max = a1;
Console.WriteLine($"Максимальная цифра число {num} -> {max}");