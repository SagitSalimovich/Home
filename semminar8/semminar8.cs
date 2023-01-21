// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите значение m:");
// int m = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите значение n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// SortArray(array);
// PrintArray(array);


// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");

//         }
//         Console.WriteLine();
//     }

// }


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }


// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int f = 0; f < array.GetLength(1) - 1; f++)
//             {
//                 if (array[i, f] < array[i, f + 1])

//                 {
//                     int temp = array[i, f + 1];
//                     array[i, f + 1] = array[i, f];
//                     array[i, f] = temp;
//                 }
//             }
//         }
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] line = new int[4, 4];
// FillArray(line);
// PrintArray(line);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i <  array.GetLength(0); i++)
//     {
//         for (int j = 0; j <  array.GetLength(1); j++)
//         {
//             array [i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int minSumLine = 0;
// int sumLine = SumLineEl(line, 0);

// for (int i = 0; i < line.GetLength(0); i++)
// {
//     int tempSumLine = SumLineEl(line, i);
//     if (sumLine > tempSumLine)
//     {
//         sumLine = tempSumLine;
//         minSumLine = i;
//     }
// }

// Console.WriteLine($"\n{minSumLine + 1} строка с наименьшей суммой элементов ({sumLine})");

// int SumLineEl(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите размер 1 матрицы:  ");
// int[,] arrayA = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
// for (int i = 0; i < arrayA.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayA.GetLength(1); j++)
//     {
//         Console.Write("[{0}, {1}] = ", i, j);
//         arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// Console.WriteLine("Введите размер 2 матрицы:  ");
// int[,] arrayB = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
// for (int i = 0; i < arrayB.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayB.GetLength(1); j++)
//     {
//         Console.Write("[{0}, {1}] = ", i, j);
//         arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// Console.WriteLine("Матрица А:");
// PrintArray(arrayA);
// Console.WriteLine("Матрица В: ");
// PrintArray(arrayB);
// Console.WriteLine("Произведение двух матриц: ");
// Multiplication(arrayA, arrayB);
// PrintArray(Multiplication(arrayA,arrayB));



// void PrintArray(int[,] a)
// {
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             Console.Write("{0} ", a[i, j]);
//         }
//         Console.WriteLine();
//     }
// }


//  int[,] Multiplication(int[,] arrayA, int[,] arrayB)
// {
//     if (arrayA.GetLength(1) != arrayB.GetLength(0)) throw new Exception ("Матрицы должны быть одиннаковые по размеру");
//     int[,] result = new int[arrayA.GetLength(0),arrayB.GetLength(1)];
//     for (int i = 0; i <arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1) ; j++)  
//         {
//             for (int k = 0; k < arrayB.GetLength(0); k++)
//             {
//                 result[i,j] += arrayA[i,k] * arrayB[k,j];
//             }
//         }
//     }
//     return result;
// }


// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите значение m:");
// int m = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите значение n:");
// int n = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите значение z:");
// int z = Convert.ToInt32 (Console.ReadLine());

// int[,,] array3D = new int[m, n, z];


// FillArray(array3D);
// PrintArray(array3D);
// Console.WriteLine();


// void FillArray(int[,,] array)
// {
//     int countCell = m * n * z;
//     if (countCell > 100)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     array[i, j, k] = new Random().Next(10, 100);
//                 }
//             }
//         }
//     }
//     else
//     {
//         int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//         int number;
//         for (int i = 0; i < temp.GetLength(0); i++)
//         {
//             temp[i] = new Random().Next(10, 100);
//             number = temp[i];
//             if (i >= 1)
//             {
//                 for (int j = 0; j < i; j++)
//                 {
//                     while (temp[i] == temp[j])
//                     {
//                         temp[i] = new Random().Next(10, 100);
//                         j = 0;
//                         number = temp[i];
//                     }
//                     number = temp[i];
//                 }
//             }
//         }
//         int count = 0;
//         for (int x = 0; x < array3D.GetLength(0); x++)
//         {
//             for (int y = 0; y < array3D.GetLength(1); y++)
//             {
//                 for (int z = 0; z < array3D.GetLength(2); z++)
//                 {
//                     array3D[x, y, z] = temp[count];
//                     count++;
//                 }
//             }
//         }
//     }
// }


// void PrintArray(int[,,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

