// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] FillArray (int rowsToFill, int columnsToFill)
{
    Random rand = new Random();
    int[,] tempArray = new int[rowsToFill, columnsToFill];

    for (int i = 0; i < rowsToFill; i++)
    {
        for (int j = 0; j < columnsToFill; j++)
        {
            tempArray[i, j] = rand.Next(0, 10); 
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

int[,] arrayA = FillArray(5, 6);
Console.WriteLine("Исходная матрица");
ShowArray(arrayA);

int minSum = 0;
int minSumRow = 0;

for (int j = 0; j < arrayA.GetLength(1); j++)
{
    minSum += arrayA[0, j];
}

for (int i = 1; i < arrayA.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        sum += arrayA[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minSumRow = i;
    }
}

Console.WriteLine($"Строка {minSumRow + 1} матрицы с наименьшей суммой чисел {minSum}");
Console.WriteLine("(порядок строк с единицы)");