/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int [] GetArray (int size) // Заполняем массив случайными трехзначными числами 
{
    var array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-1000,1000);
    }
    return array;
}

void PrintArray (int[]array) // Выводим наш массив
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write ($"{array[i]} ");
}
}


int Metod (int[] array) // Метод поиска суммы
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2 != 0)
         sum++;
    }
    return sum;
}

try

{
Console.WriteLine ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size);
PrintArray(array);
int sumOddNumber = Metod (array);
Console.WriteLine("");
Console.WriteLine (sumOddNumber);

}
catch (Exception ex)
{
 Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
