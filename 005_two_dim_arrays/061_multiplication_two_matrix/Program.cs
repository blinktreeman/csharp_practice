// Найти произведение двух матриц

int[,] FillArray (int rowsToFill, int columnsToFill)
{
    Random rand = new Random();
    int[,] tempArray = new int[rowsToFill, columnsToFill];

    for (int i = 0; i < rowsToFill; i++)
    {
        for (int j = 0; j < columnsToFill; j++)
        {
            tempArray[i, j] = rand.Next(0, 2); 
        }
    }
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

int[,] firstMatrix = FillArray(3, 4);
Console.WriteLine("Матрица А");
ShowArray(firstMatrix);
int[,] secondMatrix = FillArray(4, 5);
Console.WriteLine("Матрица B");
ShowArray(secondMatrix);
int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int multiplication = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            multiplication += firstMatrix[i, k] * secondMatrix[k, j];
        }
        resultMatrix[i, j] = multiplication;
    }
}

Console.WriteLine("Произведение матриц АхВ:");
ShowArray(resultMatrix);