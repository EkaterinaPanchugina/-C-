// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
void WeekDay (int num)

{


if (num == 6) {Console.WriteLine("Да");}
else if (num == 7) {Console.WriteLine("Да");}
else if (num > 0 && num < 7) {Console.WriteLine("Нет");}
else 
{
Console.WriteLine("Нет такого дня недели");
}
}

Console.Write("Введите номер дня недели:");
int num = int.Parse(Console.ReadLine());

WeekDay(num);
