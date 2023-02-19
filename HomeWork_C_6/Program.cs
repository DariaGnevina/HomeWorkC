/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

/*
Console.Write("Введите числа через пробел: "); 
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0: {count}"); */

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);
Console.WriteLine($"точка пересечения двух прямых: ( {x}, ; {y})");
*/