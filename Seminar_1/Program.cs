/*
// 1 задача: Ввести число с консоли, и вернуть на консоль его квадрат

Console.Write("Ведите целое число:");

int value = Convert.ToInt32(Console.ReadLine());

int Kvadrat_value = value * value;

Console.Write("Квадрато этого числа равен ");

Console.WriteLine(Kvadrat_value);


// 2 Задача ввести 2 числа и узнать является ли одно квадратом второго

Console.Write("Ведите первое целое число:");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число:");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
        Console.Write("Первое число является квадратом втогрого");
}
else
{
        Console.Write("Первое число не является квадратом втогрого");
}


// 3 Задача Напишите программу, которая будет выдавать название дня недели по заданному номеру.


Console.Write("Чтобы узнать день недели введите число:");

int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)

{
    if(number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if(number == 2)
    {
        Console.WriteLine("Вторник");
    }
    if(number == 3)
    {
        Console.WriteLine("Среда");
    }
    if(number == 4)
    {
        Console.WriteLine("Четверг");
    }
    if(number == 5)
    {
        Console.WriteLine("Пятница");
    }
    if(number == 6)
    {
        Console.WriteLine("Ура! Суббота");
    }
    if(number == 7)
    {
        Console.WriteLine("Ура! Воскресенье");
    }
else 
{
   Console.WriteLine("Такого дня недели не существует"); 
}

// Задача 4 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n * (-1);

while(neg_n <= n)
{
    Console.Write(neg_n + " ");
    neg_n++;
}

// Работа со switch
Console.Write("Чтобы узнать день недели введите число:");

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
    {
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {    
        Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        Console.WriteLine("Среда");
        break;
    }
     case 4:
    {
        Console.WriteLine("Четверг");
        break;
    }   
    case 5:
    {
        Console.WriteLine("Пятница");
        break;
    }    
     case 6:
    {
        Console.WriteLine("Ура! Суббота");
        break;
    }   
     case 7:
    {
        Console.WriteLine("Ура! Воскресенье");
        break;
    }   
    default:
    {
        Console.WriteLine("Такого дня недели не существует");
        break;
    }
}
*/
