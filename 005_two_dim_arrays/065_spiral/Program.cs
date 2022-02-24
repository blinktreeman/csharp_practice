// Спирально заполнить двумерный массив:
// 1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int[,] RotateArray(int[,] inputArray)
{
    // Transpose matrix
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = i + 1; j < inputArray.GetLength(1); j++)
        {
            int temp = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = temp;
        }
    }
    // Mirror horizontally
    for (int i = 0; i < inputArray.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            int temp = inputArray[i, j];
            inputArray[i, j] = inputArray[inputArray.GetLength(0) - 1 - i, j];
            inputArray[inputArray.GetLength(0) - 1 - i, j] = temp;
        }
    }
    return inputArray;
} 

void ShowArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j], -3} ");
        }
        Console.WriteLine();
    }
}

int[,] spiralArray = new int[4, 4];
int indexI = 0, 
    indexJ = 0;

for (int i = 1; i <= spiralArray.GetLength(0) * spiralArray.GetLength(1); i++)
{
    if (indexJ < spiralArray.GetLength(1) && spiralArray[indexI, indexJ] == 0)  // Пока не достигли конца строки
    {                                                                           // и значение в масиве равно 0
        spiralArray[indexI, indexJ] = i;                                        // 1 2 3 4
        indexJ++;                                                               // 0 0 0 0 
    }                                                                           // 0 0 0 0
    else                                                                        // 0 0 0 0
    {
        int temp = indexJ;                                                      // иначе вращаем матрицу против
        indexJ = indexI + 1;                                                    // часовой стрелки и продолжаем
        indexI = spiralArray.GetLength(1) - temp;                               // 4 5 0 0
        spiralArray = RotateArray(spiralArray);                                 // 3 0 0 0
        spiralArray[indexI, indexJ] = i;                                        // 2 0 0 0
        indexJ++;                                                               // 1 0 0 0
    }
}
// Вращать пока 1 не будет в позиции 0, 0
while (spiralArray[0, 0] != 1) RotateArray(spiralArray);
ShowArray(spiralArray);
