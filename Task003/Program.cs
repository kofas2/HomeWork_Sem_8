// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} \t");

        }
        Console.WriteLine();
    }
}




Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[,] array2 = new int[rows, cols];

FillArray(array);
FillArray(array2);
Console.WriteLine("Матрица 1");
PrintArray(array);
Console.WriteLine("Матрица 2");
PrintArray(array2);

ProdMatrix(array, array2);

Console.WriteLine("Произведение матриц 1 и 2");
int[,] array3 = ProdMatrix(array,array2);
PrintArray(array3);


int[,] ProdMatrix(int[,] array, int[,] array2)
{
    if (array.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] prodMatr = new int [array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                prodMatr[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return prodMatr;
}


// using System;
 
// namespace ConsoleApplication1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите размерность первой матрицы: ");
//             int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
//             for (int i = 0; i < A.GetLength(0); i++)
//             {
//                 for (int j = 0; j < A.GetLength(1); j++)
//                 {
//                     Console.Write("A[{0},{1}] = ", i, j);
//                     A[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
//             Console.WriteLine("Введите размерность второй матрицы: ");
//             int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
//             for (int i = 0; i < B.GetLength(0); i++)
//             {
//                 for (int j = 0; j < B.GetLength(1); j++)
//                 {
//                     Console.Write("B[{0},{1}] = ", i, j);
//                     B[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
 
//             Console.WriteLine("\nМатрица A:");
//             Print(A);
//             Console.WriteLine("\nМатрица B:");
//             Print(B);
//             Console.WriteLine("\nМатрица C = A * B:");
//             int[,] C = Multiplication(A, B);
//             Print(C);
 
//         }
//         static int[,] Multiplication(int[,] a, int[,] b)
//         {
//             if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
//             int[,] r = new int[a.GetLength(0), b.GetLength(1)];
//             for (int i = 0; i < a.GetLength(0); i++)
//             {
//                 for (int j = 0; j < b.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < b.GetLength(0); k++)
//                     {
//                         r[i,j] += a[i,k] * b[k,j];
//                     }
//                 }
//             }
//             return r;
//         }
//         static void Print(int[,] a)
//         {
//             for (int i = 0; i < a.GetLength(0); i++)
//             {
//                 for (int j = 0; j < a.GetLength(1); j++)
//                 {
//                     Console.Write("{0} ", a[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }
