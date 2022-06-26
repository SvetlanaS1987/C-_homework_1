/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* Console.WriteLine("Введите целое число А");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число B");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Число А возведенной в натуральную степень числа В ");
Console.Write(Math.Pow(num, num2) + " "); */


/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.WriteLine("Введите целое число");
int a = int.Parse(Console.ReadLine());
int s = 0;
while (a > 0)
{
    s = s + a % 10;
    a = a / 10;
}
Console.WriteLine("Сумма цифр в числе");
Console.WriteLine(s);
 */

/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

/* int [] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 9);
  
}
void PrintArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}
PrintArray(array); */