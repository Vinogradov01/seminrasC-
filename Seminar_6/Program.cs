// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// A < B + C
/*
void triangle(int a, int b, int c)
{
    if (a < (b + c) && b < (c + a) && c < (b + a)) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник с такими сторонами не может существовать");
}
Console.Write("Введите длинну стороны A ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длинну стороны B ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длинну стороны C ");
int C = Convert.ToInt32(Console.ReadLine());
triangle(A, B, C);
*/
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
void transformation(int number)
{
    string answer = string.Empty;
    while (number > 0)
    {
        answer = Convert.ToString(number%2) + answer;
        number = number / 2;
    }
    Console.Write(answer);
}
Console.Write("Введите число  ");
int input = Convert.ToInt32(Console.ReadLine());
transformation(input);
*/
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
void fibonacci(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    Console.Write("0 1 ");
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }
}
Console.Write("Введите число  ");
int input = Convert.ToInt32(Console.ReadLine());
fibonacci(input);
*/
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
