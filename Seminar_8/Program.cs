
// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Console.WriteLine("Massiv");
// int row = Convert.ToInt32(Console.ReadLine());
// int col = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[row, col];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-9, 10);
//         Console.Write(array[i, j] + " ");
//     }
// }   Console.WriteLine();
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     int temp = array[0, j];
//     array[0, j] = array[row-1, j];
//     array[row-1, 4] = temp;
// }
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
// }   Console.WriteLine();

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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[,] SwapRow(int[,] cluster)
{
    int temp;
    for (int j = 0; j < cluster.GetLength(1); j++)
    {
        temp = cluster[0, j];
        cluster[0, j] = cluster[cluster.GetLength(0) - 1, j];
        cluster[cluster.GetLength(0) - 1, j] = temp;
    }
    return cluster;
}

void PrintArray(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Изменённый массив");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, column];
CreateFillArray(array);
Console.WriteLine();
PrintArray(SwapRow(array));


// Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

// int[,] MirrorgArray(int[,] massif)
// {
//     int temp;
//     if (massif.GetLength(0) == massif.GetLength(1))
//     {
//         for (int i = 0; i < massif.GetLength(0); i++)
//         {
//             for (int j = i; j < massif.GetLength(1); j++)
//             {
//                 temp = massif[i, j];
//                 massif[i, j] = massif[j, i];
//                 massif[j, i] = temp;
//             }
//         }
//     }
//     else Console.WriteLine("Длинна массива не соответсвует его ширене, замена не возможна");
//     return massif;
// }
// CreateFillArray(array);
// Console.WriteLine();
// PrintArray(MirrorgArray(array));


// Console.WriteLine("Massiv");
// int row = Convert.ToInt32(Console.ReadLine());
// int col = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[row, col];
// if (row != col) Console.WriteLine("imbosible");
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-9, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// int count = 0;
// for (int i = 0; i < row && count <= (row * col) / 2; i++)
// {
//     for (int j = i; j < col; j++)
//     {
//         int temp = array[i, j];
//         array[i, j] = array[j, i];
//         array[j, i] = temp;
//         count++;
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// int[,] CrossCuter(int[,] array)
// {
//     int minElement = 0,
//         indexI = 0,
//         indexJ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] > minElement)
//             {
//                 minElement = array[i, j];
//                 indexI = i;
//                 indexJ = j;
//             }
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[indexI, i] = 0;
//     }
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[j, indexJ] = 0;
//     }
//     return array;
// }
// Console.Write("Введите количество строк в массиве: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[row, column];
// CreateFillArray(array);
// Console.WriteLine();
// PrintArray(CrossCuter(array));

