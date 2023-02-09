Random rnd = new Random();
int x = rnd.Next(3,6);
int y = rnd.Next(3,6);
int z = rnd.Next(3,6);
int countNums = 90;

if (x * y * z > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] arrayNums = Create3DMassive(x, y, z);

for (int i = 0; i < arrayNums.GetLength(0); i++)
{
    for (int j = 0; j < arrayNums.GetLength(1); j++)
    {
        for (int k = 0; k < arrayNums.GetLength(2); k++)
        {
            Console.Write($"{arrayNums[i, j, k]} [{i},{j},{k}] \t");
        }
        
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
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
