// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Console.WriteLine("Введите размер массива");
// int M = Convert.ToInt32(Console.ReadLine()); 
// int [] array = new int [M];
// FillArray(array);
// PrintArray(array);
// CountNum(array);
// Console.WriteLine($"Чисел больше 0 -> {CountNum(array)}");


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return ;
// }


// void PrintArray (int[] array)
// { 
//     for (int i = 0; i < array.Length; i++)
//        Console.Write($"{array[i]}");
//     Console.WriteLine();
// }


// int CountNum (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count += 1;
//     }
//     return count;
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5

// Console.WriteLine("Введите угловой коофициент k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите коофициент смещения b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите угловой коофициент k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите коофициент смещения b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// double x=0;
// double y=0;


// if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
// else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
// else 
//     {
//     x=(b2-b1)/(k1-k2) ;
//     y=k1*x+b1;
//     Console.WriteLine($"Пересечение в точке: ({x} ; {y})");  
//     }
