// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] makeArray (int rws, int cols)
{
    Random rand = new Random();
    int[,] tempArray = new int[rws, cols];

    for (int i = 0; i < rws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempArray[i, j] = rand.Next(0, 10); 
        }
    }
    return tempArray;
}

void showArray(int[,] tempArr)
{
    for (int i = 0; i < tempArr.GetLength(0); i++)
    {
        for (int j = 0; j < tempArr.GetLength(1); j++)
        {
            Console.Write($"{tempArr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arrayA = makeArray(3, 3);
Console.WriteLine("Исходный массив");
showArray(arrayA);

for (int j = 0; j < arrayA.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        sum += arrayA[i, j];
    }
    Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {sum / arrayA.GetLength(0)}");
}
