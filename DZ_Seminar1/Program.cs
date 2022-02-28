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

__________________________________________________________________________________________________________________________________________

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

______________________________________________________________________________________________________________________________________

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Давайте узнаем является ли число чётным?");

Console.Write("Введите целое число:");

int number1 = Convert.ToInt32(Console.ReadLine());

int result = number1 % 2;
 if (result == 0)
    {
        Console.Write("Это число является чётным");
    }
 else
 {
     Console.Write("Это число является не чётным");
 }

_________________________________________________________________________________________________________________________

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Хотите узнать какие есть чётные числа, в промежутке от еденицы до числа которыое вы загадали?");

Console.Write("Введите целое число:");

int number1 = Convert.ToInt32(Console.ReadLine());

int count = 1;

while(count < number1) 
{
    if(count % 2 == 0)
    Console.Write( count + "  ");
    count++;
}
*/