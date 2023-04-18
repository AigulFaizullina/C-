// Задание 1.
// using System;
// using static System.Console;
// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
 
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
 
// SortArray(array);
// PrintArray(array);
 

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }
 
// int[,] SortArray(int[,] inArray)
// {
//     int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
//     int i=0;
//     while(i<inArray.GetLength(0))
//     {
//         for (int k = 0; k < inArray.GetLength(0); k++)
//         {
//             for (int j = 0; j < inArray.GetLength(1)-1; j++)
//                 {
           
//                     if (inArray[k,j] > inArray[k,j+1])
//                     {
//                         int c = inArray[k,j];
//                         inArray[k,j] = inArray[k,j+1];
//                         inArray[k,j+1] = c;
//                     }
//                 }
//         }
//         i++;
//     }
//     return result;
// }
 

// Задание 2.
// using System;
// using static System.Console;
// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
 
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
 
// SumArray(array);
 

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }
 
// void SumArray(int[,] inArray)
// {   int sum=0;
//     int numbers=0;
//     for (int j = 0; j < inArray.GetLength(1)-1; j++)
//     {
//         sum+=inArray[0,j];
//     }
//     for (int i = 1; i < inArray.GetLength(0); i++)
//     {   int sum2=0;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//             {
//                 sum2+=inArray[i,j];
//             }  
//         if (sum2<sum)
//         {
//             sum=sum2;
//             numbers=i;    
//         }
//     }
//     WriteLine(numbers);
// }



// Задание 3.
// using System;
// using static System.Console;
// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
 
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// int[,] array2 = GetArray(rows, columns, 0, 10);
// PrintArray(array2);
// WriteLine();
 
// PrintArray(MatrixMultiplication(array,array2));
 

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }
 
// int [,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {  
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
 
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             matrixC[i, j] = 0;
 
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }
//     }
 
//     return matrixC;
// }

//  Задание 4.
// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }
// Задание 5.
// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

