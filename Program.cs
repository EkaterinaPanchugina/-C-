//Подсказываем, что именно нужно сделать пользователю
Console.Write("Введите число №1:");
//ReadLine просит ввести данные, принимает в любом формате, Parse преобразует строку String в int
int number_a = int.Parse(Console.ReadLine());

Console.Write("Введите число №2:");
int number_b = int.Parse(Console.ReadLine());

if  (number_a>number_b)
{
    Console.WriteLine($"минимальное значение = {number_b}, максимальное значение = {number_a}");
}
if (number_a<number_b)
{
    Console.WriteLine($"минимальное значение = {number_a}, максимальное значение = {number_b}");
}
if (number_a==number_b)
{
    Console.WriteLine("числа равны");
}