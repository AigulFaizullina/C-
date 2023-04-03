// Задание 1.
// int power(int a, int b){
//     int power=1;
//     for (int i=1; i<=b;i++)
//         power*=a;
//     return power;
// }
// Console.Write("Введите число: ");
// int a=int.Parse((Console.ReadLine()));
// Console.Write("Введите степень: ");
// int b=int.Parse((Console.ReadLine()));
// Console.Write($"{a}^{b} = {power(a,b)}");
 
// Задание 2.
// int sum(int num){
//     int sum=0;
//     while (num>0){
//         sum+=num%10;
//         num=num/10;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int num=int.Parse((Console.ReadLine()));
// Console.Write($"{num} = {sum(num)}");
 
// Задание 3.
// int[] array(int size){
//     int[] arr=new int[size];
//     for (int i=0; i<size;i++){
//         Console.Write("Введите число: ");
//         arr[i]=int.Parse((Console.ReadLine()));}
//     return arr;
// }
// Console.Write("Введите размер массива: ");
// int size=int.Parse((Console.ReadLine()));
// Console.Write(String.Join(", ",array(size)));
