// Задание 1.
// using System;
// using static System.Console;
// Clear();
// Write("Введите число от: ");
// int number_1 = int.Parse(ReadLine());
// Write("Введите число до: ");
// int number_2 = int.Parse(ReadLine());
// Write(WriteNow(number_1,number_2));
// string WriteNow(int number_1,int number_2)
// {if (number_1==number_2){
//     return number_2.ToString();
// }
//     return number_1+", "+WriteNow(--number_1,number_2);
// }

// Задание 2.
// using System;
// using static System.Console;
// Clear();
// Write("Введите число от: ");
// int number_1 = int.Parse(ReadLine());
// Write("Введите число до: ");
// int number_2 = int.Parse(ReadLine());
// Write(WriteNow(number_1,number_2));
// int WriteNow(int number_1,int number_2)
// {if (number_1==number_2){
//     return number_2;
// }
//     return number_1+WriteNow(++number_1,number_2);
// }

// Задание 3.
// using System;
// using static System.Console;
// Clear();
// Write("Введите число M: ");
// int m = int.Parse(ReadLine());
// Write("Введите число N: ");
// int n = int.Parse(ReadLine());
// Write(Akkerman(m,n));
// int Akkerman(int m,int n)
// {
//     if (m==0){
//         return n+1;
//     }
//     else if (n==0 && m>0){
//         return Akkerman(m-1,1);
//     }
//     else{
//         return (Akkerman(m-1,Akkerman(m,n-1)));
//     }


// }