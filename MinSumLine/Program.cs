Console.WriteLine("введите размер прямоугольного массива");
int arraySize = int.Parse(Console.ReadLine()!);
Console.WriteLine("****************************");
int[,] array = new int[arraySize, arraySize];              //Создаем массив
FillArray(array);                                           //Вызов метода для заполнения массива
PrintArray(array);
Console.WriteLine("****************************");
SearchMinSumLine(array);                                    //Вызов метода для поиска минимального значения суммы

void SearchMinSumLine(int[,] array)                        // Метод поиска минимальнной суммы по строкам
{
    int minSize = 0;                                        
    int minSumRow = 0;                                     
    int sumLine = 0;                                         
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSize = minSize + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sumLine = sumLine + array[i, j];
        }
        if (sumLine < minSize)
        {
            minSize = sumLine;
            minSumRow = i;
        }
        sumLine = 0;
    }
    Console.Write($"Наименьшая сумма в {minSumRow + 1} строке ({minSize})");
}
void PrintArray(int[,] array)                               //Метод вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)                            //Метод заполнения массива псевдослучайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}