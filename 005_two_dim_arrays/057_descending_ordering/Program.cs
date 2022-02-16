// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

// Fill a two-dimensional array with random numbers
int[,] FillArray (int rows, int columns)
{
    Random rand = new Random();
    int[,] tempArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            tempArray[i, j] = rand.Next(0, 10); 
        }
    }
    return tempArray;
}

// Show a two-dimensional array
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

// Sort in descending order
int[] SortArrayDescending(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        int maxNumber = inputArray[i];
        int maxNumberIndex = i;

        for (int j = i + 1; j < inputArray.Length; j++)
        {
            if (inputArray[j] > maxNumber)
            {
                maxNumber = inputArray[j];
                maxNumberIndex = j;
            } 
        }
       
        if (inputArray[i] < maxNumber)
        {
            int temp = inputArray[i];
            inputArray[i] = inputArray[maxNumberIndex];
            inputArray[maxNumberIndex] = temp;
        }
    }

    return inputArray;
}

int[,] arrayA = FillArray(5, 6);
Console.WriteLine("Исходный массив");
ShowArray(arrayA);

// For each row
for (int i = 0; i < arrayA.GetLength(0); i++)
{
    int[] tempArray = new int[arrayA.GetLength(1)];
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        tempArray[j] = arrayA[i, j];
    }
    
    tempArray = SortArrayDescending(tempArray);
    
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        arrayA[i, j] = tempArray[j];
    }
}

Console.WriteLine("Полученный массив. Cортировка элементов строк по убыванию");
ShowArray(arrayA);
