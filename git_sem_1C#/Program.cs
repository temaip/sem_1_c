// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input secod number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
//  Console.WriteLine("a= " + a + ", b= " + b + " -> " + " max= "+ a);
//   else 
//    Console.WriteLine("a= " + a + ", b= " + b + " -> " + "max= " + b);


// //   Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.  

// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input secod number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a > b && a > c)
// Console.WriteLine("a= " + a + ", b= " + b + ", c= " + c + " -> " + " max= " + a);
// if (b > a && b > c)
// Console.WriteLine("a= " + a + ", b= " + b + ", c= " + c + " -> " + "max= " + b);
// if (c > a && c > b)
// Console.WriteLine("a= " + a + ", b= " + b + ", c= " + c + " -> " + "max= " + c);

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if ((N % 2) == 0)
// Console.WriteLine(N + " -> чётное ");
// else
// Console.WriteLine(N + " -> нечётное ");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x: ");// нужно ввести 1
int x = Convert.ToInt32(Console.ReadLine());
for ( x; N; x++ )
if (( x%2 )== 0)
Console.WriteLine(N + "->" + x);



