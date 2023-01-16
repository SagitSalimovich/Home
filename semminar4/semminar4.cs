// Использование функций обязательно, начиная с этого ДЗ!
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите  число А"); 
// int numA = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите  число Б"); 
// int numB = Convert.ToInt32(Console.ReadLine()); 
// int res = steppen(numA, numB); 

// Console.WriteLine($"Результат возведения числа {numA} в степень {numB} = {res}");

// int steppen(int numA, int numB) 
// { 
//     int result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         result = result * numA;
//     }
//     return result; 
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите  число ");
// int numA = Convert.ToInt32(Console.ReadLine());
// int count = count_num(numA);

// int x = sum_num(numA, count);
// Console.WriteLine($"в числе {numA} сумма цифр составляет {x}");

// //функция суммирует цифры в числе
// int sum_num(int numA, int count)
// {
//     int res = 0;
//     for (int i = 1; i <= count; i++)
//     {
//         res = res + (((numA % (steppen(10, i)))) / (steppen(10, i - 1)));
//     }
//     return res;
// }

// // функция считает кол-во цифр в числе
// int count_num(int num) 
// {
//     if (num < 0)
//         num = num * (-1);
//     int temp = 0;
//     if (num < 10)
//     {
//         temp = 1;
//     }
//     else
//     {
//         double baseten = Math.Log10(num);

//         temp = Convert.ToInt32(Math.Truncate(baseten));
//         temp = temp + 1;
//     }

//     return temp;
// }
// //функция возведения в степень
// int steppen(int numA, int numB) 
// { 
//     int result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         result = result * numA;
//     }
//     return result;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

// int size = 8;
// int[] array = CreateArray(size);
// PrintArray(array);

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }
