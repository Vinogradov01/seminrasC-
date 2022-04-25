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
    string[,] massStr = new string[array.GetLength(0), array.GetLength(1)];
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string resultRow = String.Empty;
        for (int j = 0; j < i + 1; j++)
        {
            massStr[i, j] = array[i, j].ToString();
            if (massStr[i, j] == "0") massStr[i, j] = " ";
            resultRow += $"{massStr[i, j]} ";
        }
        Console.SetCursorPosition((Console.WindowWidth - resultRow.Length) / 2, Console.CursorTop);
        Console.Write(resultRow);
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateTriangle(num));