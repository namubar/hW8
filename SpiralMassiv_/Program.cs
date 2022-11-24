// Console.WriteLine("Введите размер массива");
// int size = int.Parse(Console.ReadLine()!);

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }


//Console.WriteLine("Введите размер массива");
//int size = int.Parse(Console.ReadLine()!);

int[,] array = new int[4, 4];                            //

int number = 1;
int i = 0;
int j = 0;
int size = 4;
void fillArray (int [,]array)
{
while (number <= size * size)
{
    array[i, j] = number;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++number;
}
}
fillArray (array);

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] <=9)
            Console.Write("0" + array[i, j] + "  ");
            else
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}