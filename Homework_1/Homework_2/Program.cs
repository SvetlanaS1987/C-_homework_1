/* Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
/* 
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int c1 = num / 10;
int c2 = c1 % 10;
Console.Write(c2); */


/* Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/* Console.WriteLine("Введите цифру, которая обозначает день недели: ");
int number = int.Parse(Console.ReadLine());

if (number <= 0 || number > 7)
{
Console.WriteLine("Введите нужное число");
}
  
else if (number < 6)
{
   Console.WriteLine("Нет");
}

else if (number == 6)
{
    Console.WriteLine("Да");
}

else if (number == 7)
{
    Console.WriteLine("Да");
} */