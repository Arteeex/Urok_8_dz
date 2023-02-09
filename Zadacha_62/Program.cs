Console.Clear();

Console.Write("Введите размер спирали: ");
int N = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [N, N];

int num = 1;
int i = 0;
int j = 0;

while(num <= N * N)
{
    array[i,j] = num;
    if(i <= j + 1 && i + j < N-1)
    j++;
    else if (i < j && i + j >= N - 1)
        ++i;
    else if (i >= j && i + j > N - 1)
        --j;
    else
        --i;
    ++num;
}
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       // Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
      //  Console.Write("]");
        Console.WriteLine("");
    }
}
