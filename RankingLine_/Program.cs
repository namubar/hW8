int[,] numbers = new int[4, 3];                              //Задан массив с установленной размерностью
FillArray(numbers);                                         //Заполнение массива с помощью метода                                   
Console.WriteLine();
Console.WriteLine("Изначальные значения элементов");
PrintArray(numbers);                                        // Вывод изначального массива с помощью метода

SortArray(numbers);                                        //Запуск алгоритма сортировки с помощью метода
Console.WriteLine();
Console.WriteLine("Значения элементов после сортировки");
PrintArray(numbers);                                        //Вывод массива после сортировки

void SortArray(int[,] array)                                   //Метод "Сортировка по строкам"
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int n = 0; n < numbers.GetLength(1) - 1; n++)
            {
                if (numbers[i, n] < numbers[i, n + 1])
                {
                    int temp = numbers[i, n];
                    numbers[i, n] = numbers[i, n + 1];
                    numbers[i, n + 1] = temp;
                }
            }
        }
    }
}

void FillArray(int[,] array)                                //Метод "Заполнение массива псевдослучайными числами"
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)                               //Метод "Вывод массива"
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

