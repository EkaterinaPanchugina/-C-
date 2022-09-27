// Развернуть массив
Console.Write("Введите число: ");
    int number = int.Parse (Console.ReadLine());   
    
    if (number <=0 )
    Console.WriteLine("Число не является палиндромом");
    else
    {
    int oldValue = number;
    int newValue = 0;
            while (number > 0)
            {
                int tmp = number % 10;
                newValue = newValue * 10 + tmp;
                number = number / 10;
            }
            if (newValue == oldValue)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
    }     
       

