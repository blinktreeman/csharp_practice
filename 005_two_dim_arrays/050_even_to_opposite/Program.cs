﻿// В двумерном массиве n×k заменить четные элементы на противоположные (?)

int[,] makeArray (int rws, int cols)    // Generate array
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

void showArray (int[,] tempArr)          //Show array
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

int[,] changeElements (int[,] chArray)
{
    for (int i = 0; i < chArray.GetLength(0); i++)
    {
        for (int j = 0; j < chArray.GetLength(1) / 2; j++)
        {
            if (j % 2 != 0) 
            {
                int tempNum = chArray[i, j];
                chArray[i, j] = chArray[i, chArray.GetLength(1)-(j+1)];
                chArray[i, chArray.GetLength(1)-(j+1)] = tempNum;
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

int[,] arrayA = makeArray(rows, columns);

Console.WriteLine("Исходный массив");
showArray(arrayA);
arrayA = changeElements(arrayA);
Console.WriteLine("Измененный массив");
showArray(arrayA);
