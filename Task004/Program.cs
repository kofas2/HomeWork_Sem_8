// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int x = 2;
int y = 2;
int z = 2;
int[,,] array = new int[x, y, z];
FillArray3D(array);
PrintArray3D(array);


void FillArray3D(int [,,] array)
{
Random random = new Random();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int k = 0; k < z; k++)
        {
            array[i, j, k] = random.Next(10, 100);
        }
    }
}
}

void PrintArray3D(int [,,] array)
{
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int k = 0; k < z; k++)
        {
            if (i == 3 && j == 3 && k == 3)
            {
                Console.Write("  ");
                break;
            }
            else
            {
                if (array[i, j, k] > 1)
                    Console.Write($"{array[i, j, k], 3}({i},{j},{k})   ");
                else
                {
                    Console.Write(array[i, j, k] + "  ");
                }
            }
        }
    }
    Console.WriteLine();
}
}
