// Написать программу, которая обменивает элементы первой строки и последней строки

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

int[,] arrayA = makeArray(5, 6);
Console.WriteLine("Исходный массив");
showArray(arrayA);

for (int j = 0; j < arrayA.GetLength(1); j++)
{
    int temp = arrayA[0, j];
    arrayA[0, j] = arrayA[arrayA.GetLength(0) - 1, j];
    arrayA[arrayA.GetLength(0) - 1, j] = temp;
}

Console.WriteLine("Полученный массив");
showArray(arrayA);
