// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
long exponentiation(long baza, long indicator)
{
    long result = 1;
    for (int i = 0; i != indicator; i++)
        {
        result = result * baza;
        }
    return result;
}
Console.WriteLine("Хотите возвести число в степень?");
Console.Write("Введите основание числа: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {input} в степени {number} равно  " + exponentiation(input, number));

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumNumber(int input)
{
    int sum = 0;
    int cont = 0;
    while (input > 0 )
    {

        cont = input % 10;
        input = input / 10;
        sum = sum + cont;
    }
    return sum;
}
Console.Write("Что бы узнать из скольки симвлов состоит число введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int answer = sumNumber(number);
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе {number} равна {answer}");

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Console.WriteLine("Введите массив из 8 элементов:");

for (int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write(array[0]);
for (int i = 1; i < 8; i++)
{
    Console.Write(", " + array[i]);
}
*/
