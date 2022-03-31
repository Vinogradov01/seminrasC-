// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
void CountPosetiveNumber(int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите число: ");
        int container = Convert.ToInt32(Console.ReadLine());
        if (container > 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел больше нуля равно {count}");
}
Console.Write("Введите колличество чисел которые будете сравнивать: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CountPosetiveNumber(input);
*/

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, 
// а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1
/*
async void BorderFromOne(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i != 0 && i != m - 1 
            && j != 0 && j != n - 1)
            array[i, j] = 0;
            else array[i, j] = 1;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
BorderFromOne(str, col);
*/
























// Console.Clear();
// Console.WriteLine("________________________________________________________");
// Console.WriteLine("Знакомство с языками программирования. Семинар 6. "); Console.WriteLine();
// Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры М чисел. ");
// Console.WriteLine("Посчитайте, сколько чисел больше 0 ввёл пользователь.");
// Console.WriteLine("________________________________________________________"); Console.WriteLine();

// task41();

// void task41()
// {
// Console.Write("Введите количество чисел: М = ");
// int M = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("");

// Console.Write("Введите " + M);
// int wm = M % 10;
// switch (wm)
//         {
//             case 1:
//                 Console.WriteLine(" положительное или отрицательное число: ");
//                 break;
//             case 2:
//                 Console.WriteLine(" положительных или отрицательных числа: ");
//                 break;
//             case 3:
//                 Console.WriteLine(" положительных или отрицательных числа: ");
//                 break;
//             case 4:
//                 Console.WriteLine(" положительных или отрицательных числа: ");
//                 break;

//             default: Console.WriteLine(" положительных или отрицательных чисел: ");
//                 break;
//         }

// int count = 0;
// for (int i = 0; i < M; i++)
// {
//     Console.Write(i + 1  + ") "); int n = Convert.ToInt32(Console.ReadLine());
//     if (n > 0) count++;    
// }
// Console.WriteLine("________________________________________________________");
// Console.WriteLine("Количество чисел больше 0: " + count);
// }
// Console.ReadLine();