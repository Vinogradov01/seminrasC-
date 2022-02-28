// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Давайте поиграем в сравнение чисел");

Console.Write("Введите первое целое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число:");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("Первое число больше чем второе  ");  Console.Write(" max="); Console.Write(a); Console.Write(" min="); Console.Write(b); 
}
else
{
    Console.Write("Второе число больше чем первое  ");  Console.Write(" max="); Console.Write(b); Console.Write(" min="); Console.Write(a); 
}
*/
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Давайте узнаем какое число больше");

Console.Write("Введите первое целое число:");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число:");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число:");

int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write("Максимальное число = ");
Console.WriteLine(max);