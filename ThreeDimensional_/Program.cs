int[,,] creatArray(int size1, int size2,int size3)
{
    int[,,] array = new int[size1, size2, size3];                
    int[] values = new int[90];                                  
    int number = 10;                                                                                
    for (int i = 0; i < values.Length; i++)
        values[i] = number++;
    for (int i = 0; i < values.Length; i++)
    {
        int random = new Random().Next(10, values.Length);
        int temp = values[i];
        values[i] = values[random];
        values[random] = temp;
    }
    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
int[,,] result = creatArray(2, 2, 2);                       //сохраняем значение в переменной и передаем его в качестве аргумента след. методу.
printArray(result);

void printArray(int[,,] array)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                Console.Write($" {result[i, j, k]} - ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}







