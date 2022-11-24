Console.WriteLine ("Введите размер матриц: ");
int size = int.Parse (Console.ReadLine()!);

int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArray(matrixA);
FillArray(matrixB);
int[,] matrixC = new int[size, size];
ResultMatrix (matrixA, matrixB);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine("");
    }
}
void ResultMatrix (int[,] matrixA, int [,] matrixB)
{
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int n = 0; n < size; n++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, n] * matrixB[n, j]);
        }
    }
}
}
Console.WriteLine("А");
PrintArray(matrixA);
Console.WriteLine("**************");
Console.WriteLine("В");
PrintArray(matrixB);
Console.WriteLine("***************");
Console.WriteLine("А*В");
PrintArray(matrixC);