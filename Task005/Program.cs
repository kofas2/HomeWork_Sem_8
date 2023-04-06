// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Спиральный массив: ");
var array2 = CreateSnakeArrayVsClock(number, number);

for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        Console.Write($"{array2[i, j],3}  ");
    }
    Console.WriteLine();
}


int[,] CreateSnakeArrayVsClock(int n, int m)
{
    var array = CreateSnakeArray(n, m);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n / 2; j++)
        {
            var tmp = array[j, i];
            array[j, i] = array[j, m - i - 1];
            array[j, m - i - 1] = tmp;
        }
    }
    return array;
}

int[,] CreateSnakeArray(int n, int m)
{
    int[,] A = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0;
    int dirChanges = 0, gran = m;

    for (int i = 0; i < A.Length; i++)
    {
        A[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        row += dx;
        col += dy;
    }
    return A;
}