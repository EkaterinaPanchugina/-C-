// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
void SecondNumber(int num)

{

//Проверяем, является ли число трехзначным)

if (num < 99 && num > -99) {Console.WriteLine("Число не является трехзначным");}
else if (num > 999) {Console.WriteLine("Число не является трехзначным");}
else if (num < -999) {Console.WriteLine("Число не является трехзначным");}


else if (num > 99 && num < 1000)
{
    num = num/10;
    int second = num%10;
    Console.WriteLine($"Вторая цифра в вашем числе = {second}");
}

else if (num < -99 && num > -999)
{
    int num1 = Math.Abs(num);
    num1 = num1/10;
    int second = num1%10;
    Console.WriteLine($"Вторая цифра в вашем числе = {second}");
}
}

Console.Write("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());

SecondNumber(num);
