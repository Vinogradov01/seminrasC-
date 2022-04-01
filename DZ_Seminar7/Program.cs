// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
void FillArrayRealNumbers(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
FillArrayRealNumbers(str, col);
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

/*
void ViewElementOfPosition(int m, int n)
{
    int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
    if (m >= 0 && m <= 2 && n >= 0 && n <= 3)
    {
        Console.WriteLine($"На этом месте находится элемент {array[m, n]}");
    }
    else Console.WriteLine("такого числа в массиве нет");
}
Console.Clear();
Console.Write("Введите индекс в строке: ");
int colN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс в столбце: ");
int strM = Convert.ToInt32(Console.ReadLine());
ViewElementOfPosition(strM, colN);
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
var mean0Colum = 0.0;
var mean1Colum = 0.0;
var mean2Colum = 0.0;
var mean3Colum = 0.0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        switch (j)
        {
            case 0:
                {
                    mean0Colum = mean0Colum + array[i, j];
                    break;
                }
            case 1:
                {
                    mean1Colum = mean1Colum + array[i, j];
                    break;
                }
            case 2:
                {
                    mean2Colum = mean2Colum + array[i, j];
                    break;
                }
            case 3:
                {
                    mean3Colum = mean3Colum + array[i, j];
                    break;
                }
        }
    }
}
Console.WriteLine(Math.Round(mean0Colum / 3, 1));
Console.WriteLine(Math.Round(mean1Colum / 3, 1));
Console.WriteLine(Math.Round(mean2Colum / 3, 1));
Console.WriteLine(Math.Round(mean3Colum / 3, 1));
Console.WriteLine(Math.Round(4.49, 1));