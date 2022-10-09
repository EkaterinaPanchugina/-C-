/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNumber(int number1, int number2)
{
    if (number2 > number1)
    {
        number2 = number2 + SumNumber(number1, number2 - 1);
    }
    
    if (number2 == number1)
    {
        number2 = number2 * 0;
    }
    return number2;
}
Console.WriteLine("ВВедите значение M : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N : ");
int number2 = Convert.ToInt32(Console.ReadLine());


int result = SumNumber(number1,number2);
Console.WriteLine($"Сумма чисел в промежутке от {number1} до {number2}: {result}");
