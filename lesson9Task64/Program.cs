/* Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

string OutputNumbers(int x)
{
    string result = "";
    if (x == 1)
    {
        result = "1";
    }
    else
    {
          result = $"{x}" + "," +OutputNumbers(x - 1);
    }
    return result;
}



Console.WriteLine("Введите значение N : ");
int number = Convert.ToInt32(Console.ReadLine());
string result = OutputNumbers(number);
Console.WriteLine($"Промежуток от N {number} до 1 : {result}");
