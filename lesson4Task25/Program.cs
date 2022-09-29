/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Решить задачу с использованием методов.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
int raiseAtoThePowerOfB(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
    // Либо пойти простым путем через int result = Math.Pow(numberA, numberB);
  }
    
    return result;
}


  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = raiseAtoThePowerOfB(numberA, numberB);
  Console.WriteLine($"Результат ={exponentiation}");
