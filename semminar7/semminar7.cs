// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Double [,] array = new Double [ m, n ];
// FillArray(array);
// PrintArray(array);


// void FillArray(Double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(1,10);
// }


// void PrintArray( Double [,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j] } \t");
//         Console.WriteLine();
//     }
// }





// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите строку: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец: ");
// int col = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int [lines, col];

// if (lines < matrix.GetLength(0) && col  <matrix.GetLength(1)) Console.WriteLine(matrix[lines, col]);
// else Console.WriteLine($"{lines}{col} -> такого числа в массиве нет");


// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j ++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// void FillArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//           matr[i,j] = new Random().Next(1,10);  
//         }
//     }
// }
// FillArray(matrix);
// PrintArray(matrix);




   
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];
// double sum = 0;
// double result = 0;
// FillArray(matrix);
// PrintArray(matrix);
// Sum(matrix);

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// void Sum (int[,] matr)
// { for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//       for (int i = 0; i < matrix.GetLength(1); i++)
//       {
//         sum += matrix[i, j];
//       }
   
//     result = sum / matrix.GetLength(1);
//     result = Math.Round(result, 2);
//     Console.Write(result + "- Среднее арифметическое столбца " );
//     result = 0;
//     sum = 0;
//    }
// }