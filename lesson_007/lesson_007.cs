// Задание 1.
// using System;
// using static System.Console;
 
// Clear();
 
// Write("Введите количество строк массива: ");
// int rows=int.Parse(ReadLine());
 
// Write("Введите количество столбцов массива: ");
// int columns=int.Parse(ReadLine());
 
// double[,] array = GetArray(rows, columns);
 
// PrintArray(array);
 
// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*10;
//         }
//     }
//     return result;
// }
 
// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i,j]:F2} ");
//         }
//         WriteLine();
//     }
// }
 
// Задание 2.
// using System;
// using static System.Console;
 
// Clear();
 
// Write("Введите количество строк массива: ");
// int rows=int.Parse(ReadLine());
 
// Write("Введите количество столбцов массива: ");
// int columns=int.Parse(ReadLine());
 
// int[,] array = GetArray(rows, columns, 0, 10);
 
// Write("Введите i: ");
// int i_num=int.Parse(ReadLine());
 
// Write("Введите j: ");
// int j_num=int.Parse(ReadLine());
 
// PrintArray(array);
// ArrayValue(array);
 
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i,j]} ");
//         }
//         WriteLine();
//     }
// }
 
// void ArrayValue(int[,] inArray)
// {if (i_num>inArray.GetLength(0) | j_num>inArray.GetLength(1))
// {
//     WriteLine($"такого числа в массиве нет");
// }
// else
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         { if (i ==i_num && j==j_num)
//         {
//             Write($"Значение массива - {inArray[i,j]} ");
//         }
//         }
//     }
// }}
 
// Задание 3.
// using System;
// using static System.Console;
 
// Clear();
 
// Write("Введите количество строк массива: ");
// int rows=int.Parse(ReadLine());
 
// Write("Введите количество столбцов массива: ");
// int columns=int.Parse(ReadLine());
 
// int[,] array = GetArray(rows, columns, 0, 10);
 
// PrintArray(array);
// average(array);
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i,j]} ");
//         }
//         WriteLine();
//     }
// }
// void average(int[,] inArray)
 
// {   int sum=0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             sum+=inArray[i,j];
//         }
//         var avg= (double) sum/columns;
//         Write($"{avg:F2}; ");
//     }
// }
