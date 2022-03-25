// Задача 1 Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int SumToA(int num)
{
    var sum = (num*(num+1))/2;
    return sum;
}
Console.Write("Что бы узнать интересную информацию введитн целое число ");
var input = (Convert.ToInt32(Console.ReadLine()));
if (input>0)
{
    var number = SumToA(input);
    Console.WriteLine($"Сумма всех чисел от нуля до {input} равна " + number);
}
else Console.WriteLine("Вы ввели не полжительное число! ");
*/

// Задача 2 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int totalNumber(int input)
{
    int lenght = 1;
    while (Math.Abs(input / 10) > 0)
    {
        input = input / 10;
        lenght++;
    }
    return lenght;
}
Console.Write("Что бы узнать из скольки симвлов состоит число введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int answer = totalNumber(number);
Console.WriteLine($"Число {number} состоит из {answer} цифр");
*/
// Задача 3 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
long SumToA(int num)
{
    long sum = 1;
    if (num == 0)
    {
        return sum;
    }
    int variable = 2;
    while (variable <= num)
    {
        sum = sum * variable;
        variable++;
    }
    return sum;
}
Console.Write("Что бы узнать факториал, введите целое число ");
var input = (Convert.ToInt32(Console.ReadLine()));
if (input > -1)
{
    var number = SumToA(input);
    Console.WriteLine($"Факториал числа {input} равен " + number);
}
else Console.WriteLine("Вы ввели не полжительное число! ");
*/
// Задача 4 Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
