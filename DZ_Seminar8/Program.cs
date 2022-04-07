// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
/*
int[,] CreateFillArray(int[,] matrix)
{
    Console.Write("Введите число, минимальную границу диапазона чисел в массиве: ");
    int minBorder = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число, максимальную границу диапазона чисел в массиве: ");
    int maxBorder = Convert.ToInt32(Console.ReadLine());
    Console.Write("Исходный массив: ");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minBorder, maxBorder);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matrix;
}
*/
/*
void PrintArray(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Изменённый массив");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}
*/
/*
int[,] SortDescending(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[x, j] < array[x, min])
                {
                    min = j;
                }
            }
            int tmp = array[x, i];
            array[x, i] = array[x, min];
            array[x, min] = tmp;
        }
    }
    return array;
}
*/

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int MinimumAmountLine(int[,] array)
{
    int minSumRow = int.MaxValue;
    int indexMinRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }

        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexMinRow = i;
        }
    }
    return indexMinRow;
}

*/
// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)
/*
int[,,] CreateFillArray3D(int[,,] matrix3D)
{
    int num = new Random().Next(10, 20);
    for (int z = 0; z < matrix3D.GetLength(0); z++)
    {
        for (int x = 0; x < matrix3D.GetLength(1); x++)
        {
            for (int y = 0; y < matrix3D.GetLength(2); y++)
            {
                matrix3D[z, x, y] = num;
                num = num + new Random().Next(1, 9);
                Console.Write($"{matrix3D[z, x, y]}\t");
            }
        }
        Console.WriteLine();
    }
    return matrix3D;
}
/*
void PrintArray3D(int[,,] array3D)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Изменённый массив");
    Console.WriteLine();
    for (int z = 0; z < array3D.GetLength(0); z++)
    {
        Console.WriteLine("Page" + " " + (z + 1));
        for (int x = 0; x < array3D.GetLength(1); x++)
        {
            for (int y = 0; y < array3D.GetLength(2); y++)
            {
                Console.Write($"{array3D[z, x, y]} ({z},{x},{y})\t");
            }
            Console.WriteLine();
        }
    }
    Console.ForegroundColor = ConsoleColor.White;
}
*/


// Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
/*
int[,] Speral(int[,] body)
{
    int n = body.GetLength(0);
    int num = 1;
    int increment = 0;
    while (increment < n / 2)
    {
        for (int j = increment; j < n - increment; j++)
        {
            body[increment, j] = num; num++;
        }
        for (int i = increment + 1; i < n - increment; i++)
        {
            body[i, n - increment - 1] = num; num++;
        }
        for (int j = n - increment - 2; j > increment; j--)
        {
            body[n - increment - 1, j] = num; num++;
        }
        for (int i = n - increment - 1; i > increment; i--)
        {
            body[i, increment] = num; num++;
        }
        increment++;
    }
    if ((n % 2) != 0) body[n / 2, n / 2] = num;
    return body;
}
*/
// Console.Write("Введите количество страниц в массиве: ");  // Задача 3
// int page = Convert.ToInt32(Console.ReadLine());  //Задача 3
// Console.Write("Введите количество строк в массиве: ");  // Задача 1 -- Задача 1 -- Задача 2 -- Задача 3
// int row = Convert.ToInt32(Console.ReadLine());  // Задача 1 -- Задача 2 -- Задача 3
// Console.Write("Введите количество столбцов в массиве: ");  // Задача 1 -- Задача 2 -- Задача 3
// int column = Convert.ToInt32(Console.ReadLine());  // Задача 1 -- Задача 2 -- Задача 3
// Console.Write("Введите число обозначающее количество строк и столбцов: ");  // Задача 4
// int n = Convert.ToInt32(Console.ReadLine());  //Задача 4
// int[,] array = new int[row, column];  // Задача 1 -- Задача 2 -- Задача 3
// int[,,] array3D = new int[page, row, column];  // Задача 3
// int[,] array = new int[n, n];  //Задача 4
// CreateFillArray(array);  // Задача 1 -- Задача 2 -- Задача 3
// PrintArray(SortDescending(array));  // Задача 2
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinimumAmountLine(array)}");  // Задача 2
// CreateFillArray3D(array3D);  //Задача 3
// PrintArray3D(array3D);  //Задача 3
// PrintArray(Speral(array));  //Задача 4