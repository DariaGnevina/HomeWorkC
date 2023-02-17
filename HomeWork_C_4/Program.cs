/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

    Console.WriteLine("Введите два числа");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (b >= 1)
    {
        Console.Write($"Число {a} в степени {b} равно {Math.Pow(a,b)}");
    }
    else{
        Console.WriteLine("Повторите ввод: первое число должно быть целым, второе - натуральным");
    }

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {break;}
        else 
        {
            Console.WriteLine("Ввели не число или число отрицательное. Повторите ввод:");
        }
    }
    return result;
    
}
int number = GetNumber("Введите положительное число");
int GetSumm(int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ += number % 10;
        number /= 10; 
    }
    return summ;
}

int summ = GetSumm(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {summ}"); 




/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int m = 8;
int [] arr = new int [m];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0,1000);
}
Console.WriteLine(string.Join(", ", arr));
