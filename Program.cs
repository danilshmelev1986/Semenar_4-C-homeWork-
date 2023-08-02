// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine ("give me a first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("give me a second number");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = 1; 
//    for (int i = 0; i<b; i++)
   
//      {
//          result = result*a;
//               }
//      Console.WriteLine (result);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ("give me a number");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum()
{
    int sum =0;
    
    while (num>0)
    {
      int digit = num % 10; // Получаем последнюю цифру числа
      sum += digit; // Суммируем цифру с общей суммой
      num /= 10; // Убираем последнюю цифру из числа
    }
    
    return sum;
}

int result = GetSum();
Console.WriteLine (result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];

// void GetArray()
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+"");
//     }
// }
// GetArray();