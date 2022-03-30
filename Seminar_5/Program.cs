// Задача 1. Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9]. 
// Найти сумму положительных элементов, и сумму отрицательных элементов массива.

/*
int[] array = new int[12];
int pos = 0;
int neg = 0;
 Console.Write("Массив: ");
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(" " + array[i]);
    if (array[i] > 0) pos = pos + array[i];
    else neg = neg + array[i];
}
Console.WriteLine();
Console.WriteLine("Сумма положительных елементов в массиве = " + pos);
Console.WriteLine("Сумма отрицательных елементов в массиве = " + neg);
*/

// Задача 2. Напишите программу замены элементов массива: положительные элементы заенить на отрицательные и наоборот.
/*
int[] array = new int[12];
Console.Write("                 Массив:");
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(" " + array[i]);
}
Console.WriteLine();
Console.Write("Инвертированный массив: ");
for (int i = 0; i < 12; i++)
{
    Console.Write(" " + array[i] * (-1));
}
*/

// Задача 3. Задайте массив. Напишите программу, которая определяет, присудствует ли введенно число в массиве.
/*
int[] array = new int[10];
Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
int indicator = 0;
Console.Write("Массив: ");
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(" " + array[i]);
    if(input == array[i])
    {
        indicator = 1;
        break;
    }
}
Console.WriteLine();
if(indicator == 1) Console.WriteLine("Такое число есть!");
else Console.WriteLine("Такого числа нет!");
*/
// Задача 4. Задайте одномерный массив из 123 случайных чисел, Найдите колличчествоэлементов массива, значения которых лежат в отрезке [10, 99]



// Задача 5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат записать в новом массиве.

