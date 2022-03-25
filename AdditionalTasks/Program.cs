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


// Решение этой задачи, решение не моё.
/*
 int max1=int.MinValue,max2=int.MinValue,min1=int.MaxValue,min2=int.MaxValue; // Присвоение переременным, значений минимальных и максимальных констант.
 int input,n=0;
 Console.WriteLine("Enter your numbers individually, the program will finish after you enter 0:");
 while (true)  // Безусловный цикл
 {
    input = Convert.ToInt32(Console.ReadLine());   
    if (input == 0) break;
    n++;

    if (max1<=input)
        {
            max2 = max1;
            max1 = input;           
            
        }

    if (min2>=input)
    {
        min2 = min1;
        min1 = input;
    }

 }
  
if(n<2) Console.WriteLine("You entered less than three numbers needed for program to work correctly");
else Console.WriteLine($"Highest numbers are {max1} and {max2}, lowest numbers are {min1} and {min2}");
*/