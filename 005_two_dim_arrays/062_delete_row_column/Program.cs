// В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

void ShowArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] initialArray = { { 2, 3, 4, 5 }, { 3, 4, 0, 5 }, { 4, 5, 6, 7 }, { 5, 6, 7, 8 } };

int minNumber = initialArray[0, 0];
int[] minNumberIndex = {0, 0};

for (int i = 0; i < initialArray.GetLength(0); i++)
{
    for (int j = 0; j < initialArray.GetLength(1); j++)
    {
        if (initialArray[i, j] < minNumber)
        {
            minNumber = initialArray[i, j];
            minNumberIndex[0] = i;
            minNumberIndex[1] = j;
        }
    }
}

Console.WriteLine(minNumberIndex[0]);
Console.WriteLine(minNumberIndex[1]);

int[,] resultArray = new int[initialArray.GetLength(0) - 1, initialArray.GetLength(1) - 1];

int countI = 0;
int countJ = 0;

for (int i = 0; i < initialArray.GetLength(0); i++)
{
    if (i != minNumberIndex[0])
    {
        for (int j = 0; j < initialArray.GetLength(1); j++)
        {
            if (j != minNumberIndex[1])
            {
                resultArray[countI, countJ] = initialArray[i, j];
                countJ++;
            }
        }
        countI++;
        countJ = 0;
    }
}

Console.WriteLine("Исходный массив");
ShowArray(initialArray);
Console.WriteLine("Результат удаления строки и столбца с наименьшим элементом");
ShowArray(resultArray);