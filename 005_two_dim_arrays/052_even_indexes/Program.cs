// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

void ShowArray (int[,] tempArr)
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

int[,] ChangeElements (int[,] chArray)
{
    for (int i = 0; i < chArray.GetLength(0); i++)
    {
        for (int j = 0; j < chArray.GetLength(1); j++)
        {
            if (j % 2 == 0 & i % 2 == 0) 
            {
                chArray[i, j] *= chArray[i, j];
            }
        }
    }
    return (chArray);
}

Console.WriteLine("Задайте размер двумерного массива");
Console.Write("строки n=");
int rows =  int.Parse(Console.ReadLine());
Console.Write("столбцы k=");
int columns =  int.Parse(Console.ReadLine());

int[,] arrayA = MakeArray(rows, columns);

Console.WriteLine("Исходный массив");
ShowArray(arrayA);
arrayA = ChangeElements(arrayA);
Console.WriteLine("Измененный массив");
ShowArray(arrayA);
