// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


double[,] GetTwoDimensionalArray(double[,] array)
{
    Random random = new Random();
   

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)

        {
            array[i, j] = Math.Round(random.NextDouble(), 1, MidpointRounding.ToZero);
        }
    }
    return array;
}

// метод вывода массива 

void WriteTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// пользователь вводит кол-во строк в массиве
int LineTwoDimensionalArray()
{
    Console.Write("Введите колличество строк: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int m);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата");
        return LineTwoDimensionalArray();
    }
    else
    {
        return m;
    }
}

// пользователь вводит кол-во столбцов в массиве
int ColumnTwoDimensionalArray()
{
    Console.Write("Введите колличество столбцов: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int n);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата");
        return ColumnTwoDimensionalArray();
    }
    else
    {
        return n;
    }
}

// метод создания массива  
double[,] MakeTwoDimensionalArray()
{
    int m = LineTwoDimensionalArray();
    int n = ColumnTwoDimensionalArray();
    double[,] array = new double[m, n];
    return array;
}



//создаем массив
double[,] array = MakeTwoDimensionalArray();
//заполняем рандомными числами
array = GetTwoDimensionalArray(array);
//вывод массива
WriteTwoDimensionalArray(array);
