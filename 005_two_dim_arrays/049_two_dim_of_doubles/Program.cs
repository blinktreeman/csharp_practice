// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] FillArray (int rws, int cols)
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

void ShowArray(double[,] inputArray)
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

Console.WriteLine("Задайте размер двумерного массива");
Console.Write("строки m=");
int rows =  int.Parse(Console.ReadLine());
Console.Write("столбцы n=");
int columns =  int.Parse(Console.ReadLine());

double[,] arrayA = FillArray(rows, columns);
ShowArray(arrayA);