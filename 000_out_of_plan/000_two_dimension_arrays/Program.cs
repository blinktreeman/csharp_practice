// 

int[,] FillArray (int rowsToFill, int columnsToFill)
{
    Random rand = new Random();
    int[,] tempArray = new int[rowsToFill, columnsToFill];

    //foreach (int i in tempArray) i.Value = rand.Next(0, 10); 
        
    return tempArray;
}

void ShowArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arrayA = FillArray(3, 3);
Console.WriteLine("Исходная матрица");
ShowArray(arrayA);

foreach (int i in arrayA)
{
    Console.WriteLine($"{i} ");
}