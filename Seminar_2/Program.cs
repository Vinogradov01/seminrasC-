// Семинар 2 часть 1

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


//Семинар 2 часть 2

// Задача Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

int getQuart(double xPoint, double yPoint)
{
    if (xPoint > 0 && yPoint > 0) return 1;
    if (xPoint < 0 && yPoint > 0) return 2;
    if (xPoint < 0 && yPoint < 0) return 3;
    if (xPoint > 0 && yPoint < 0) return 4;
    return 0;
}
double x, y;
int quartNum;
Console.Write("Input X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y: ");
y = Convert.ToDouble(Console.ReadLine());
quartNum = getQuart(x, y);
if (quartNum == 0) Console.WriteLine("Нельзя однозначно определить четверть");
else Console.WriteLine("Данная точка находится в  " + quartNum + "  четверти");


//  Задача  Написать программу, которая принимает на вход номер четверти ивыводит на экран диапазон координат, доступных в этой четверти

void quart(int num)
{
    switch (num) 
    {
        case 1:
        {
            Console.WriteLine(" ");
            Console.WriteLine("В этой четверти координады Х и  координаты У будут положительными");
            break;
        }
        case 2:
        {
            Console.WriteLine(" ");
            Console.WriteLine("В этой четверти координаты Х будут отрицательными, а координаты У будут положительными");
            break;
        }
        case 3:
        {
            Console.WriteLine(" ");
            Console.WriteLine("В этой четверти координаты Х и координаты У будут отрицательные");
            break;
        }
        case 4:
        {
            Console.WriteLine(" ");
            Console.WriteLine("В этой четверти координаты Х будут положительные, а координаты У будут отрицательные");
            break;
        }
        default:
        {
            Console.WriteLine(" ");
            Console.WriteLine("Такой четверти не существует!");
            break;
        }
    }    
}

Console.Write("Для того чтобы узнать с каким знаком будут координтаты в одной из чевертей введите четверть: ");
int number = Convert.ToInt32(Console.ReadLine());
quart(number);




//  Задача Написать программу, которая на вход получает координаты точек Х и У  и выдаёт расстояние между точками.
/*
double getDistans(double x1, double y1, double x2, double y2)
{
    double xDistans = x1 - x2;
    double yDistans = y1 - y2;

    return Math.Sqrt(Math.Pow(xDistans, 2) + Math.Pow(yDistans, 2));
}
double xA, yA, xB, yB;
double distans;
Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
distans = getDistans(xA, yA, xB, yB);
Console.WriteLine(distans);
*/