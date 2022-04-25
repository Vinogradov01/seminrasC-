// Задача 1.  Написать программу, которая на вход принимает 2 числа, и выдаст первое n чисел для которых каждое следующее равно сумме двух предыдущих.
/*
int Fibo(int ferst, int second, int size)
{
    if (size == 1) return ferst;
    if (size == 2) return second;
    else return Fibo(ferst, second, size - 1) + Fibo(ferst, second, size - 2);
}
Console.Write("Введите первое число ряда: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ряда: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну ряда: ");
int s = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= s; i++)
{
    Console.Write($"{Fibo(n1, n2, i)}  ");
}
*/
// Задача 2. Имеетря алфофит с конкретными символами, необходимо показать все слова состоящие из n букв которые можно построить из букв этого алфавита.

void FineWords(string abc, int lenghtAbc, string word)
{
    if (lenghtAbc == 0) Console.WriteLine(word);
    else
    {
        for (int i = 0; i < abc.Length; i++)
        {
            FineWords(abc, lenghtAbc - 1, word + abc[i]);
        }
    }
}
FineWords("X1#", 3, "");









// Задача 3. Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data 
// хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений 
// чисел массива data с учётом информации из массива info.
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1