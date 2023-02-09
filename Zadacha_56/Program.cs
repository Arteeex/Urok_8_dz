Console.Clear();
Random rnd = new Random();
int M = rnd.Next(6,10);
int N = rnd.Next(3,5);
int [,] arrayTable = new int [M, N];
int minsum = Int32.MaxValue;
int count = 0;
for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i,j] = rnd.Next(20);
        
         
    }
}
for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        Console.Write(arrayTable[i,j] + " ");
        
    }
    Console.Write("]");
    Console.WriteLine();
}

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        sum += arrayTable[i,j];
    }
        if (sum < minsum)
        {
            minsum = sum;
            count++;
        }
}

Console.WriteLine("Cтрока с наименьшей суммой елементов под номером: " + (count) + ", с суммой елементов равной: " + (minsum));