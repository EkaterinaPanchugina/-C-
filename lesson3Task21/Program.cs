// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double GetDistanceThreePoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
double distance = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
return distance;
}

Console.Write("Введите Х1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите Х2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());

//Расчет расстояния
double result = GetDistanceThreePoints(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между двумя точками равно({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");
