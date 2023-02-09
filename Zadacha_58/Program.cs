Console.Clear();

Console.Write("Размерность матриц: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
int[,] matrix3 = new int[size, size];

void FillArrayRandomNumbers(int[,] array)
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
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
FillArrayRandomNumbers(matrix1);
FillArrayRandomNumbers(matrix2);

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrix3);