﻿/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.WriteLine("Введите numberA");
int numberA = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите numberB");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);  */

/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* Console.WriteLine("Введите numberA");
int numberA = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите numberB");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите numberC");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC; 

Console.Write("max = ");
Console.WriteLine(max); */

/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/* Console.WriteLine("Введите numberA");
int numberA = int.Parse(Console.ReadLine()); 

if (numberA%2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
} */

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

/* Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()); 

for (int i = 1; i <= N; i++)       
if (i%2==0) 

Console.Write(i + " "); */