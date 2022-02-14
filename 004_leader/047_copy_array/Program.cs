// Написать программу копирования массива

Console.WriteLine("Исходный массив");
int[] arrayA = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Console.WriteLine(string.Join(" ", arrayA));

int[] arrayB = new int[arrayA.Length];

// arrayB = arrayA;

for (int i=0; i < arrayA.Length; i++)
{
    arrayB[i] = arrayA[i];
}

Console.WriteLine("Результат копирования");
Console.WriteLine(string.Join(" ", arrayB));