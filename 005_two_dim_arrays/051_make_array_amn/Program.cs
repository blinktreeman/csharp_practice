// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] FillArray (int rws, int cols)
{
    int[,] tempArray = new int[rws, cols];

    for (int i = 0; i < rws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            // Amn = m + n
            tempArray[i, j] = i + j; 
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

Console.WriteLine("Задайте размер двумерного массива");
Console.Write("строки m=");
int rows =  int.Parse(Console.ReadLine());
Console.Write("столбцы n=");
int columns =  int.Parse(Console.ReadLine());

int[,] arrayA = FillArray(rows, columns);
ShowArray(arrayA);