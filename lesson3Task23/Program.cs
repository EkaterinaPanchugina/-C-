// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int[] GetCubesNumer(int numer)
{
    int[] cubesNumers = new int[numer];

    // Заполнение массива результата
    for (int i = 1; i <= numer; i++)
    {
        cubesNumers[i - 1] = i * i * i;
    }

    return cubesNumers;
}
//Запрашиваем у пользователя число и помещаем его в переменную num
Console.Write("Input name: ");
int num = int.Parse(Console.ReadLine());

// В качестве результата нам вернется массив из кубов чисел, и передаем метод, который мы сами написали 
int[] result = GetCubesNumer(num);
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}
