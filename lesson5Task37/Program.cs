/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

 int[] GetArray(int size)
{
      var array = new int[size];  

      for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
         }
  return array;
}

int [] Method (int[] array)
{
    int [] newArray = null;

    if (array.Length % 2 == 0) //определили, что массив содержит четное кол-во знаков
    {
        newArray = new int [array.Length/2];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
        }
    }
    else
    {
        newArray = new int[array.Length / 2 + 1];
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i == newArray.Length - 1 )
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i] = array[i] * array[array.Length - i - 1];
            }
        }
    }
    return newArray;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }
    return;
}

Console.Write ("Введите размер массива: ");
int size = Convert.ToInt32 (Console.ReadLine());

int [] array = GetArray (size);
Console.WriteLine("Старый массив: ");
PrintArray (array);

int [] newArray = Method (array);
Console.WriteLine("Новый массив: ");
PrintArray (newArray);
