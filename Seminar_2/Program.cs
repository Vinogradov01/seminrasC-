// See Задача 1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindMaxNum(int num)
{
int n1 = num % 10;
int n2 = num / 10;

    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}
int number = new Random().Next(10, 99);
Console.WriteLine("Current number is " + number + " max part is " + FindMaxNum(number));


// Задача 2 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. (427-> 47)

int DelSec(int num)
{
    int n1 = (num / 100) * 10;
    int n2 = (num % 10);
    return n1 + n2;
}
int number = new Random().Next(100, 1000);
Console.WriteLine(number + "-->" + DelSec(number));


// Задача 3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деление.

void Crat(int num1, int num2)
    {
        if (num1 % num2 == 0)
        {
            Console.Write("Первое число является кратным второму");
        }
    else
    {
        Console.Write("первое число не является кратным второму, остаток от деления состовляет  " + num1 % num2);
    }
}
Console.Write("Введите первое целое число :");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число :");
int number2 = Convert.ToInt32(Console.ReadLine());

Crat(number1, number2);



// Задача 4  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно д и 23.

void Proverka(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Число " + num1 + " является кратным числам " + num2 + " и " + num3);
    }
    else
    {
        Console.WriteLine("Число " + num1 + " не является одновременно кратным числам " + num2 + " и " + num3);
    }
}
Console.Write("Введите целое число :");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число для проверки кратности первого числа :");
int check2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число для проверки кратности первого числа :");
int check3 = Convert.ToInt32(Console.ReadLine());
Proverka(number1, check2, check3);
*/