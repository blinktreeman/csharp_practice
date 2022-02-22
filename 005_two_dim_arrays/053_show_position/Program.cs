// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] FillArray (int rws, int cols)
{
    Random rand = new Random();
    int[,] tempArray = new int[rws, cols];

    for (int i = 0; i < rws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempArray[i, j] = rand.Next(0, 100); 
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

int[,] arrayA = FillArray(5, 5);
Console.WriteLine("Исходный массив");
ShowArray(arrayA);
Console.WriteLine("Задайте число из массива");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        if (arrayA[i, j] == number)
        {
            Console.WriteLine($"Число находится на {i+1} строке в столбце {j+1}");
            return;
        }
    }
}
Console.WriteLine("Такого числа нет в массиве");
