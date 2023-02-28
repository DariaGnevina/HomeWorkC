//HOMEWORK

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

/*
int GetNaturalNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        { 
            Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
        }
    }

    return result;
}

void PrintNumber(int N, int i)
{
    if (i <= N)
    {  
        Console.Write($"{N} ");
        N--;
        PrintNumber(N, i);
    }
}

Console.WriteLine();
int i = 1;
int numbers = GetNaturalNumber("Введите натуральное число: ");
PrintNumber(numbers, i);

*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*
int Summ (int m, int n)
{
    if (m == n)
    return m;
    else
    return m + Summ(m +1, n);
}
int result = Summ(1,15);
Console.WriteLine(result);
*/

/* Задача 68 :Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


int Akkerman (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
int result = Akkerman(2,3);
Console.WriteLine(result);
