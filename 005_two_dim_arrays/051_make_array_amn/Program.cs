// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] makeArray (int rws, int cols)
{
    int[,] tempArray = new int[rws, cols];

    for (int i = 0; i < rws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempArray[i, j] = i + j; 
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

Console.WriteLine("Задайте размер двумерного массива");
Console.Write("строки m=");
int rows =  int.Parse(Console.ReadLine());
Console.Write("столбцы n=");
int columns =  int.Parse(Console.ReadLine());

int[,] arrayA = makeArray(rows, columns);

showArray(arrayA);