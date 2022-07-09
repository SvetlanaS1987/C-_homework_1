/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

/* void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

int[] arr = new int[9];
for (int i = 0; i < arr.Length; i++)

{
    arr[i] = new Random().Next(100, 1000);
}

PrintArray(arr);

int count = 0;
int CountEven(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0) count++;
    }
    return count;
}

CountEven(arr);
Console.WriteLine($"Количество четных чисел в массиве: {count}"); */

/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* void PrintArray(int [] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

int[] arr = new int[4];
for (int i = 0; i < arr.Length; i++)

{
    arr[i] = new Random().Next(-1000, 1000);
}

PrintArray(arr);

int sum = 0;
int SumUnEvenPos(int[] collection)
{
    for (int i = 0; i < collection.Length; i+=2)
    {
        sum += collection[i];
    }
    return sum;
}

SumUnEvenPos(arr);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях.: {sum}"); */


/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76 */

/* double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}"); */
 