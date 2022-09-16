//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите число:");
//Просим пользователя ввести данные в формате "целое число"
int number = int.Parse(Console.ReadLine());

int startNumber = 2;
while(startNumber<=number)
{
    Console.WriteLine(startNumber);
    startNumber = startNumber+2;
}