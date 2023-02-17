 /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int [] InitArray(int dimension)
{
    int[] arr = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr [i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void EvenNumbers(int [] arr)
{
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"В заданном массиве {count} четных чисел");
}
int [] array = InitArray(10);
PrintArray(array);
EvenNumbers(array); */



/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int [] InitArray(int dimension)
{
    int[] arr = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr [i] = rnd.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void SummNumbers(int [] arr)
{
int summ = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        summ = summ + arr[i];
    }
}
Console.WriteLine($"В заданном массиве сумма чисел на нечетных позициях равна {summ}");
}
int [] array = InitArray(6);
PrintArray(array);
SummNumbers(array); */


/* Задача 38 :Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите длину массива  ");

int arr = Convert.ToInt32(Console.ReadLine());

double[] number = new double[arr];

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] number)
{
    
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    
    Console.WriteLine();
}

void MinMax(double[] number)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int a = 0; a < number.Length; a++)
    {
        if (number[a] > max)
            {
                max = number[a];
            }
        if (number[a] < min)
            {
            min = number[a];
            }
    
    }
    Console.WriteLine($" Максимальное = {max}, Минимальное = {min}");
    Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");
}
FillArrayRandomNumbers(number);
PrintArray(number);
MinMax(number);
