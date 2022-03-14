// Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
// Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел.
// А теперь самое интересное: создавать массивы в процессе решения запрещено


Console.WriteLine("Нахождение двух максимальных и двух минимальных чисел из всех что вы ввели");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int max1 = number, max2 = number, min1 = number, min2 = number;

    while (number != 0)
    {
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > max1)
        {
            max2 = max1;
            max1 = number;
        }
        else
        {
            if (number != max1 && number > max2)
            {
                min2 = max2;
                max2 = number;
            }
            else
            {
                if (number != 0 && number < min1)
                {
                    min2 = min1;
                    min1 = number;
                }
                else
                {
                    if (number != 0 && number < min2)
                    {
                        min2 = number;
                    }
                }
            }
        }
    }
    Console.WriteLine("первое максимальное число " + max1 + " второе максимальное число " + max2);
    Console.WriteLine("первое минимальное число " + min1 + " второе минимальное число " + min2);
