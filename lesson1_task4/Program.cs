//Три числа и максимум из трех чисел
//Подсказываем, что именно нужно сделать пользователю
Console.Write("Введите число №1:");
//ReadLine просит ввести данные, принимает в любом формате, Parse преобразует строку String в int
int number_a = int.Parse(Console.ReadLine());

Console.Write("Введите число №2:");
int number_b = int.Parse(Console.ReadLine());

Console.Write("Введите число №3:");
int number_c = int.Parse(Console.ReadLine());

if (number_a>=number_b && number_a>=number_c)
{
Console.WriteLine($"Максимальное число = {number_a}");
}
else if (number_b>=number_a && number_b>=number_c)
{
Console.WriteLine($"Максимальное число = {number_b}");
}
else if (number_c>=number_b && number_c>=number_a)
{
Console.WriteLine($"Максимальное число = {number_c}");
}
