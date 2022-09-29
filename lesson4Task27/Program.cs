/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

  int SumNumber(int numberN)
  {
    int count = Convert.ToString(numberN).Length;
    int tmp = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      tmp = numberN - numberN % 10;
      result = result + (numberN - tmp);
      numberN = numberN / 10;
    }
   return result;
  }


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе = {sumNumber}");
