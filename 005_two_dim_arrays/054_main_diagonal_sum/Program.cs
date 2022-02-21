// В матрице чисел найти сумму элементов главной диагонали

int[,] MakeArray (int rws, int cols)
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

void ShowArray(int[,] tempArr)
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

int[,] arrayA = MakeArray(5, 5);
Console.WriteLine("Исходный массив");
ShowArray(arrayA);

int sum = 0;

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        if (i == j)
        {
            sum += arrayA[i, j];
        }
    }
}
Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");
