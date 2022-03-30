// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int count = 0;
int fill(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
        if((array[i]%2) == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    return count;
}
Console.Write("Введите число, которое обозначит сколько элементов будет в массиве ");
int input = Convert.ToInt32(Console.ReadLine());
int[] matrix = new int[input];
fill(matrix);
Console.WriteLine($"В массиве {count} четных елементов");
*/
// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int sum = 0;
int fill(int[] array)
{
    Console.Write("Введите число: минимальную границу заполнения массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число: максимальную границу заполнения массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(min, max);
        Console.Write(array[i] + " ");
        if((i%2) == 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine();
    return sum;
}
Console.Write("Введите число, которое обозначит сколько элементов будет в массиве ");
int input = Convert.ToInt32(Console.ReadLine());
int[] matrix = new int[input];
fill(matrix);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях равна {sum}");
*/

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double diff = 0;
double fill(double[] array)
{
    Console.Write("Массив: ");
    double max = double.MinValue; 
    double min = double.MaxValue; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().NextDouble() * 200 - 100;
        Console.Write(array[i] + " ");
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}
Console.Write("Введите число, которое обозначит сколько элементов будет в массиве ");
int input = Convert.ToInt32(Console.ReadLine());
double[] matrix = new double[input];
fill(matrix);
Console.WriteLine();

Console.Write("Разница между максимальны и минимальны элементами равна ");
Console.ForegroundColor = ConsoleColor.Green; //Баловство, пхотелось попробовать)
Console.Write(diff);
Console.ForegroundColor = ConsoleColor.White;