// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Давайте узнаем является ли число палиндромом");
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 

string str = Convert.ToString(num);

if ((str[0] == str[4]) && (str[1] == str[3]))Console.WriteLine("Число является палиндромом");
else Console.WriteLine("число не является палиндромом");

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
Console.Write("Введите координату Z второй точки: ");
zB = Convert.ToDouble(Console.ReadLine());
distans = getDistans(xA, yA, zA, xB, yB, zB);
double disRound = Math.Round(distans); // просто решил поиграться с математическими операциями.
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

