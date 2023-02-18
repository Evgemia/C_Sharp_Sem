/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.Write("Введите номер дня недели: ");

int numberDayOfWeek = int.Parse(Console.ReadLine());
while(numberDayOfWeek<1 || numberDayOfWeek>7)
{
    Console.WriteLine("Введен неверный номер дня недели");
    Console.Write("Введите номер дня недели: ");
    numberDayOfWeek = int.Parse(Console.ReadLine());

}
if (numberDayOfWeek == 1)
{Console.Write("Нет");}

if (numberDayOfWeek == 2)
{Console.Write("Нет");}

if (numberDayOfWeek == 3)
{Console.Write("Нет");}

if (numberDayOfWeek == 4)
{Console.Write("Нет");}

if (numberDayOfWeek == 5)
{Console.Write("Нет");}

if (numberDayOfWeek == 6)
{Console.Write("Да");}

if (numberDayOfWeek == 7)
{Console.Write("Да");}

