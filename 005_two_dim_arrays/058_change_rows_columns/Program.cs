// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

Console.WriteLine("Задайте размер двумерного массива m*n");
Console.Write("строки m=");
int rows =  int.Parse(Console.ReadLine());
Console.Write("столбцы n=");
int columns =  int.Parse(Console.ReadLine());

if (rows != columns)
{
    Console.WriteLine("Выполнение невозможно, m <> n");
    return;
}

int[,] arrayA = FillArray(rows, columns);
Console.WriteLine("Исходная матрица");
ShowArray(arrayA);

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = i + 1; j < arrayA.GetLength(1); j++)
    {
        int temp = arrayA[i, j];
        arrayA[i, j] = arrayA[j, i];
        arrayA[j, i] = temp;
    }
}

Console.WriteLine("Транспонированная матрица");
ShowArray(arrayA);
