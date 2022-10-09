/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int Akkerman(int m, int n)
{

    if (m == 0)
    {
        return n = n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    throw new Exception(" введены неверные числа");
}



Console.WriteLine("Введите значение m : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n : ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(number1, number2);
Console.WriteLine($"Результат функции вычисления Аккермана : A({number1},{number2}) = {result}");