/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int [] GetArray (int size) // Заполняем массив случайными трехзначными числами 
{
    var array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(99,1000);
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
         if (array[i] % 2 == 0)
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
int sumEvenNumber = Metod (array);
Console.WriteLine("");
Console.WriteLine (sumEvenNumber);

}
catch (Exception ex)
{
 Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
