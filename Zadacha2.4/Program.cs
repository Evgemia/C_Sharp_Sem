/* Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет*/

Console.Clear();
Console.Write("Введите число: ");
int number =int.Parse(Console.ReadLine());

if (number % 23 == 0 && number % 7 == 0)
{
    Console.WriteLine("кратно");
    
}
else
{
    Console.WriteLine("не кратно");
}
