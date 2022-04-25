// Задача 1. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/*
void CrossLine(double b1, double k1, double b2, double k2)
{
    double xResult = (b1 - b2) / (k1 - k2);
    double yResult = k1 * xResult + b1;
    Console.WriteLine($"Точка пересечения прямых имеет координаты: x = {xResult} y = {yResult}");
}
Console.Write("Введите координату Х первой линии: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k первой линии: ");
double tgA1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х второй линии: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k второй линии: ");
double tgA2 = Convert.ToDouble(Console.ReadLine());
CrossLine(x1, tgA1, x2, tgA2);

*/
// Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1; triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}
void PrintArray(int[,] array)
{
    int n = Console.WindowWidth / 2;
    string space = string.Empty;
    string[,] massStr = new string[array.GetLength(0), array.GetLength(1)];
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Изменённый массив");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(space.PadLeft(n, ' '));
        string resultRow = String.Empty;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            massStr[i, j] = array[i, j].ToString();
            if (massStr[i, j] == "0") massStr[i, j] = " ";
            resultRow += $"{massStr[i, j]} ";
        }
        Console.SetCursorPosition((Console.WindowWidth - resultRow.Length) / 2, Console.CursorTop);
        Console.Write(resultRow);
        Console.WriteLine();
        n = n - 1;
    }
    Console.ForegroundColor = ConsoleColor.White;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateTriangle(num));