// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя

// 14212 -> нет
// 12821 -> да
// 23432 -> да


//  Console.Write("Введите пятизначное число: ");
//     string number = Console.ReadLine();

//         void CheckingNumber(string number)
//         {
//             if (number[0] == number[4] &&  number[1] == number[3])
//             {
//                 Console.WriteLine($"{number} -Да, это палиндром");
//             }
//             else Console.WriteLine($"{number} - Не палиндром");
//         }

//         if (number.Length == 5)
//         {
//             CheckingNumber(number);
//         }
//         else Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
    

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату Х1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Х2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Dist(x1, y1, z1, x2, y2, z2));

// double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//     return D;
// }


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= number; i++)
//  Console.Write($"{Math.Pow(i, 3)}. ");

