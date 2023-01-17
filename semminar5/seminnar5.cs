// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int [4];
// FillArray(array);
// PrintArray(array);
// int res = Count_num(array);
// Console.WriteLine($"в массиве {res} четных чисел");

// // создание массива
// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     array [i] = new Random().Next(100, 1000);
// }

// // вывод на экран
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          Console.WriteLine( $"{array[i]}");
//      Console.WriteLine();
// }
    
// //подсчет четных чисел
// int Count_num( int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++) 
//     {
//         if (array[i] % 2 == 0)
//             result = result + 1; 
//     }
//     return result;
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int [4];
// FillArray(array);
// PrintArray(array);
// int res = Count_num( array);
// Console.WriteLine($"в массиве сумма числе на нечетных позициях равна  {res}  ");

// // создание массива
// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     array [i] = new Random().Next(-99, 100);
// }

// // вывод на экран
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          Console.WriteLine( $"{array[i]}");
//      Console.WriteLine();
// }
    
// int Count_num( int[] array)
// {
//     int result = 0;
//     for (int i = 1; i < array.Length; i+=2) 
//     {
//            result = result + array[i]; 
//     }
//     return result;
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Console.WriteLine("Введите размер массива");
// int N = Convert.ToInt32(Console.ReadLine()); 
// double[] array = new double[N];
// FillArray(array);
// PrintArray(array);
// double resmax = FindMax(array);
// double resmin = FindMin(array);
// Console.WriteLine($"Разница между максмимальным {resmax}  и минимальным {resmin} элементом массива  {resmax - resmin}  "
// );

// // создание массива

// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     array [i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
// }

// // вывод на экран

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          Console.WriteLine( $"{array[i]}");
//      Console.WriteLine();

// }
// //поиск максимума
// double FindMax(double[] array)
// {
//     double result = array[0];
//     for (int i = 0; i < array.Length; i++) 
//     {
//        if (array[i] > result)
//        result = array[i];
//     }
//     return result;
// }
// //поиск минимума
// double FindMin( double[] array)
// {
//     double result = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < result)
//             result = array[i];
//     }
//     return result;
// }