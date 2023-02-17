// Напишите программу,которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456->46
Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;
Console.WriteLine($"{num} -> {a1} {a3}");// если с этим числом больше не нужно работать

/*Console.Clear();
int num = new Random().Next(100, 1000);
int result = (num/100) *10 + num %10;
Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {num/100}{num%10}");*/