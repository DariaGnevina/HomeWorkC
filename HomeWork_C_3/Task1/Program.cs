/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число:");
int GetNumber(int leftBound, int rightBound)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 10000 || number >= 100000)
{
    Console.WriteLine("это не пятизначное число!");
}
    return number;
}

int a = GetNumber(10000, 100000);
int FirstDigit = a / 10000;
int SecondDigit = (a / 1000) % 10;
int FourthDigit = (a / 10) % 10;
int FifthDigit = a % 10;

if (FirstDigit == FifthDigit && SecondDigit == FourthDigit)
{
    Console.WriteLine("Это палиндром");
}
else 
{
    Console.WriteLine("Это не палиндром");
}
