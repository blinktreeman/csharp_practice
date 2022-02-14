// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] makeArray (int rws, int cols)
{
    Random rand = new Random();
    double[,] tempArray = new double[rws, cols];

    for (int i = 0; i < rws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempArray[i, j] = rand.NextDouble(); 
        }
    }
    return tempArray;
}

void showArray(double[,] tempArr)
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

double[,] arrayA = makeArray(rows, columns);

showArray(arrayA);