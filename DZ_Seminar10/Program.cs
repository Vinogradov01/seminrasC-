// Задача 3. Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data 
// хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений 
// чисел массива data с учётом информации из массива info.
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; 
// четвёртое число занимает 1 бит (1 -> 1)
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

int[] DecimalViewBinar(int[] binar, int[] decNum)
{
    int [] result = new int[decNum.Length];
    int binarPosition = 0;

    for(int position = 0; position < decNum.Length; position++)
    {
        int number = 0;
        if (binarPosition + decNum[position] > binar.Length)
        {
            int cut = decNum[position] - binar.Length + binarPosition;
            while(binarPosition < binar.Length)
            {
                number = number + binar[binarPosition] * Convert.ToInt32(Math.Pow(2, binar.Length - 1 -binarPosition));
                binarPosition++;
            }
            result[position] = number;
            Console.WriteLine();
            Console.Write("не хватает данных в исходном массиве");
            return result;
        }
        for (int i = 0; i < decNum[position]; i++)
        {
            number = number + binar[binarPosition + i] * Convert.ToInt32(Math.Pow(2, decNum[position] - 1 - i));
        }
        Console.Write(number + " ");
        binarPosition = binarPosition + decNum[position];
    }
    return result;
}

int [] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int [] info = {2, 3, 3, 1};
int [] decView = DecimalViewBinar(data, info);

