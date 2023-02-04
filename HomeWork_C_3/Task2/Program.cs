/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetCoordFromUser(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) /*&& result !=0*/
        {
            break;
        }
        else{
            Console.WriteLine("Вы ввели некорректное число");
        }
    }
    return result;
}
double GetDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow (az - bz, 2));
    return result;
}
int ax = GetCoordFromUser ("Введите координаты x первой точки");
int ay = GetCoordFromUser ("Введите координаты y первой точки");
int az = GetCoordFromUser ("Введите координаты z первой точки");
int bx = GetCoordFromUser ("Введите координаты x второй точки");
int by = GetCoordFromUser ("Введите координаты y второй  точки");
int bz = GetCoordFromUser ("Введите координаты z второй  точки");

double distance = GetDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точкой с координатами ({ax},{ay},{az}) и точкой с координатами ({bx},{by},{bz}) составляет {distance}");