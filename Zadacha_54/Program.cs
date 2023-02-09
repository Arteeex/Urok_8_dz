Console.Clear();
Random rnd = new Random();
int M = rnd.Next(4,10);
int N = rnd.Next(4,10);
int [,] arrayTable = new int [M, N];

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i,j] = rnd.Next(20);
        
         
    }
}
for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        Console.Write(arrayTable[i,j] + " ");
        
    }
    Console.Write("]");
    Console.WriteLine();
}
for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        for (int k = 0; k < arrayTable.GetLength(1) -1; k++)
        {
            if (arrayTable[i,k] <  arrayTable[i, k+1])
            {
                int temp = arrayTable[i, k];
                arrayTable[i, k] = arrayTable[i, k + 1];
                arrayTable[i, k+1] = temp;
            }
        }
    }
}
Console.WriteLine("-------------------------------------");
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
