// Задайте двумерный массив размером m×n, заполненный случайными двузначными целыми числами.
/*
void СreateFillArray(int m, int n)
{
    int[,] array =new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-99, 100);
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
СreateFillArray(str, col);
*/
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
void ArraySizeByFormula(int m, int n)
{
    int[,] array =new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i+j;
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
ArraySizeByFormula(str, col);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
void SearchPrivateElements(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-2, 3);
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
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
SearchPrivateElements(str, col);
*/
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
void SumDiagonals(int m)
{
    int[,] array = new int[m, m];
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-5, 6);
            if (i == j) sum = sum + array[i, j];
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов по диагонали {sum}");
}
Console.Clear();
Console.Write("Введите число означающее кол-во строк и столбцов: ");
int strCol = Convert.ToInt32(Console.ReadLine());
SumDiagonals(strCol);
*/