// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int threeDigit(int num)
{
    int n1 = (num / 10) ;
    int n2 = (n1 % 10);
    return n2;
}
Console.WriteLine("Давайте узнаем какая цифра находится посередине числа!");
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 999 && number >= 0)
{
    Console.Write("Числом находящимся посередине является " + threeDigit(number));
}
else
{
    Console.Write("Надо именно трёхзначное!");
}

___________________________________________________________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Давайте узнаем какая цифра стоит на третьем месте в числе которое вы загадали");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 

string str = Convert.ToString(num);

if (str.Length < 3)Console.WriteLine("Во введённом числе нет третьей цифры.");
else Console.WriteLine($"Третья цифра числа равна {str[2]}");

//Альтернативный метод решения задачи № 13
Console.WriteLine("Введите число для получение");
int n = Convert.ToInt32(Console.ReadLine());
int d1 = 0, d2 = 0, d3 = 0;
while (n != 0)
{
    d3 = d2;
    d2 = d1;
    d1 = n % 10;
    n /=10;
}
Console.WriteLine(d3);

____________________________________________________________________________________________________________________________________


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void weekday(int number)
{
    if (number <= 7 && number >= 1)
    {
        if (number == 1)
        {
            Console.Write("Нет не выходной ((  сегодня понедельник");
        }
        if (number == 2)
        {
            Console.WriteLine("Нет не выходной ((  сегодня вторник");
        }
        if (number == 3)
        {
            Console.WriteLine("Нет не выходной ((  сегодня среда");
        }
        if (number == 4)
        {
            Console.WriteLine("Нет не выходной ((  сегодня четверг");
        }
        if (number == 5)
        {
            Console.WriteLine("Уже почти, но нет  сегодня пятница");
        }
        if (number == 6)
        {
            Console.WriteLine("Ура! Суббота это выходной");
        }
        if (number == 7)
        {
            Console.WriteLine("Ура! Воскресенье это выходной");
        }
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует");
    }
}
Console.WriteLine("Давайте узнаем выходной ли сегодня?");
Console.Write("Введите номер деня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
weekday(num);
__________________________________________________________________________________________________________________________


// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
*/


/*
_____________________________________________________________________________________________________________________________

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Поиск расстояния между точками, если известны коордитаны точек в трёхмерном пространстве");
double getDistans(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistans = x1 - x2;
    double yDistans = y1 - y2;
    double zDistans = z1 - z2;
    return Math.Sqrt(Math.Pow(xDistans, 2) + Math.Pow(yDistans, 2) + Math.Pow(zDistans, 2));
}
double xA, yA, zA, xB, yB, zB;
double distans;
Console.Write("Введите координату Х первой точки: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату У первой точки: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату У второй точки: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z dnjhjq точки: ");
zB = Convert.ToDouble(Console.ReadLine());
distans = getDistans(xA, yA, zA, xB, yB, zB);
double disRound = Math.Round(distans);
Console.WriteLine("Округлённое значение рассоряния = " + disRound);

____________________________________________________________________________________________________________________________________

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double cube(double n)
{
    double nCube = Math.Pow(n, 3);
    return nCube;
}
double number;
Console.Write("Чтобы узнать таблицу кубов числа, введите число: ");
number = Convert.ToInt32(Console.ReadLine());
Console.Write("1");
int count = 2;
while(count <= number) 
{
    Console.Write( ",  " + cube(count));
    count++;
}
*/
