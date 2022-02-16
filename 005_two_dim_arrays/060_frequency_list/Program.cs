// Составить частотный словарь элементов двумерного массива

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

int GetAmount(int number, int[,] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            count += inputArray[i, j] == number ? 1 : 0;
        }
    }
    return count;
}

int[,] ArraySortAscending(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int minNumber = inputArray[i, 0];
        int minNumberIndex = i;

        for (int j = i + 1; j < inputArray.GetLength(0); j++)
        {
            if (inputArray[j, 0] < minNumber)
            {
                minNumber = inputArray[j, 0];
                minNumberIndex = j;
            } 
        }

        int[,] temp = new int[1, 2];       

        if (inputArray[i, 0] > minNumber)
        {
            temp[0, 0] = inputArray[i, 0];
            temp[0, 1] = inputArray[i, 1];
            inputArray[i, 0] = inputArray[minNumberIndex, 0];
            inputArray[i, 1] = inputArray[minNumberIndex, 1];
            inputArray[minNumberIndex, 0] = temp[0, 0];
            inputArray[minNumberIndex, 1] = temp[0, 1];
        }
    }
    return inputArray;
}

int[,] arrayA = FillArray(3, 3);
Console.WriteLine("Исходная матрица");
ShowArray(arrayA);

int[,] frequencyArray = new int[arrayA.GetLength(0) * arrayA.GetLength(1), 2];

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        frequencyArray[i * arrayA.GetLength(1) + j, 0] = arrayA[i, j];
        frequencyArray[i * arrayA.GetLength(1) + j, 1] = GetAmount(arrayA[i, j], arrayA);        
    }
}

frequencyArray = ArraySortAscending(frequencyArray);

int currentNumber = frequencyArray[0, 0];
Console.WriteLine("Частотный словарь для данной матрицы");
Console.WriteLine($"{frequencyArray[0, 0]} встречается {frequencyArray[0, 1]} раз");
for (int i = 0; i < frequencyArray.GetLength(0); i++)
{
    if (frequencyArray[i, 0] != currentNumber)
    {
        Console.WriteLine($"{frequencyArray[i, 0]} встречается {frequencyArray[i, 1]} раз");
        currentNumber = frequencyArray[i, 0];
    }
}
