// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
void ThirdNumber(int num)

{

//Проверяем, есть ли третья цифра)

if (num < 99 && num > -99) {Console.WriteLine("Число не является трехзначным");}
else if (num > 999) {Console.WriteLine("Число не является трехзначным");}
else if (num < -999) {Console.WriteLine("Число не является трехзначным");}


else if (num > 99 && num < 1000)
{
        int third = num%10;
    Console.WriteLine($"Третья цифра в вашем числе = {third}");
}

else if (num < -99 && num > -999)
{
    int num1 = Math.Abs(num);
    int third = num1%10;
    Console.WriteLine($"Третья цифра в вашем числе = {third}");
}
}

Console.Write("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());

ThirdNumber(num);

